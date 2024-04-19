namespace GameUnits
{
    public class settlerUnit : Unit // Heranca!!
    {


        public settlerUnit() : base(1, 3){}

        public override float Cost{
            get{ 
                return 5f;
            }
        }

    }
}
