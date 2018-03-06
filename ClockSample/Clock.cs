namespace ClockSample
{
    public class Clock
    {
        private int ticks;

        public int Hour => (ticks / 3600) % 12;
        public int Minute => (ticks % 3600) / 60;
        public int Second => ((ticks % 3600) % 60);

        public void SetTime(int hour, int minute, int second)
        {
            ticks += hour * 3600;
            ticks += minute * 60;
            ticks += second;
        }

        public void Tick()
        {
            ticks++;
        }
    }
}
