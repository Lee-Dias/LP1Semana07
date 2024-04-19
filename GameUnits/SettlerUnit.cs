namespace GameUnits
{
    public class SettlerUnit : Unit // Heranca!!
    {


        public SettlerUnit() : base(1, 3){}

        public override float Cost{
            get{ 
                return 5f;
            }
        }

    }
}
