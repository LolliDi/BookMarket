namespace SearchPercent
{
    public static class SearchPercent
    {
        public float Search(int count)
        {
            if (count > 3)
            {
                return 0.95f;
            }
            else if (count > 5)
            {
                return 0.9f;
            }
            else if (count > 10)
            {
                return 0.85f;
            }
            else
            {
                return 1;
            }
        }
    }
}