namespace CorePoint.Infrastructure.Helper
{
    public class SnowflakeIdGenerator
    {
        private const long Twepoch = 1288834974657L; // Mốc thời gian bắt đầu (Twitter dùng), bạn có thể đổi
        private const int WorkerIdBits = 5;
        private const int DatacenterIdBits = 5;
        private const int SequenceBits = 12;

        private const long MaxWorkerId = -1L ^ (-1L << WorkerIdBits);         // 31
        private const long MaxDatacenterId = -1L ^ (-1L << DatacenterIdBits); // 31
        private const long MaxSequence = -1L ^ (-1L << SequenceBits);         // 4095

        private const int WorkerIdShift = SequenceBits;                       // 12
        private const int DatacenterIdShift = SequenceBits + WorkerIdBits;   // 17
        private const int TimestampLeftShift = SequenceBits + WorkerIdBits + DatacenterIdBits; // 22

        private long _lastTimestamp = -1L;
        private long _sequence = 0L;

        private readonly object _lock = new();
        private readonly long _workerId;
        private readonly long _datacenterId;

        public SnowflakeIdGenerator(long workerId, long datacenterId)
        {
            if (workerId > MaxWorkerId || workerId < 0)
                throw new ArgumentException($"Worker Id must be between 0 and {MaxWorkerId}");

            if (datacenterId > MaxDatacenterId || datacenterId < 0)
                throw new ArgumentException($"Datacenter Id must be between 0 and {MaxDatacenterId}");

            _workerId = workerId;
            _datacenterId = datacenterId;
        }

        public long NextId()
        {
            lock (_lock)
            {
                long timestamp = TimeGen();

                if (timestamp < _lastTimestamp)
                    throw new InvalidOperationException("Clock moved backwards. Refusing to generate id.");

                if (timestamp == _lastTimestamp)
                {
                    _sequence = (_sequence + 1) & MaxSequence;
                    if (_sequence == 0)
                    {
                        // Sequence overflow in same millisecond, wait for next
                        timestamp = WaitNextMillis(_lastTimestamp);
                    }
                }
                else
                {
                    _sequence = 0;
                }

                _lastTimestamp = timestamp;

                return ((timestamp - Twepoch) << TimestampLeftShift)
                       | (_datacenterId << DatacenterIdShift)
                       | (_workerId << WorkerIdShift)
                       | _sequence;
            }
        }

        private long WaitNextMillis(long lastTimestamp)
        {
            long timestamp = TimeGen();
            while (timestamp <= lastTimestamp)
            {
                timestamp = TimeGen();
            }
            return timestamp;
        }

        private long TimeGen()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }
    }
}
