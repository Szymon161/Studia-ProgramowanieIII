namespace Diary
{
    class Grade
    {
        private sbyte _value;
        private sbyte _weight;

        public sbyte Value
        {
            get
            {
                return _value;
            }

            set
            {
                if (value < 7)
                {
                    _value = value;
                }
                else
                {
                    throw new System.Exception("Invalid gradeValue value. Range: [0 - 6]");
                }
            }
        }

        public sbyte Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if (value > 0 && value < 4)
                {
                    _weight = value;
                }
                else
                {
                    throw new System.Exception("Invalid gradeWeigth value. Range: [1 - 3]");
                }
            }
        }

        public SchoolSubject Subject { get; private set; }

        /// <param name="gradeValue">Range: [0 - 6]</param>
        /// <param name="gradeWeigth">Range: [1 - 3]</param>
        public Grade(sbyte gradeValue, sbyte gradeWeigth, SchoolSubject subject)
        {
            Value = gradeValue;
            Weight = gradeWeigth;
            Subject = subject;
        }
    }

    public enum SchoolSubject
    {
        Maths = 0,
        English,
        IT,
        Biology,
        PE
    }
}
