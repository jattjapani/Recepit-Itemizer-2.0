namespace Receipt_Itemizer
{
    public class TaxRate
    {
        private readonly decimal ClovisTax = .08225m;
        private readonly decimal FowlerTax = .08225m;
        private readonly decimal FresnoTax = .08225m;
        private readonly decimal SelmaTax = .08725m;
        private readonly decimal VisaliaTax = .08250m;
        private readonly decimal HanfordTax = .07500m;
        private readonly decimal TulareTax = .08500m;

        public decimal SetTax(string city)
        {
            switch (city)
            {
                case "Clovis":
                    return ClovisTax;

                case "Fowler":
                    return FowlerTax;

                case "Fresno":
                    return FresnoTax;

                case "Selma":
                    return SelmaTax;

                case "Visalia":
                    return VisaliaTax;

                case "Hanford":
                    return HanfordTax;

                case "Tulare":
                    return TulareTax;

                default:
                    return 0;
            }
        }
    }
}