namespace ValueAndReferenceTypes
{
    public class RefType
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public void CheckOut(out int x)
        {
            x = 100;
            return;
        }
    }

}