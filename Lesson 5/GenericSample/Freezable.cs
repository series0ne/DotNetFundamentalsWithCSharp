namespace GenericSample
{
    using System;

    public sealed class Freezable<T>
    {
        private T value;
        private bool frozen;

        public Freezable()
        {
        }

        public Freezable(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                if (frozen)
                {
                    throw new InvalidOperationException("Cannot change a frozen value.");
                }

                this.value = value;
            }
        }

        public void Freeze()
        {
            frozen = true;
        }

        public void Unfreeze()
        {
            frozen = false;
        }
    }
}
