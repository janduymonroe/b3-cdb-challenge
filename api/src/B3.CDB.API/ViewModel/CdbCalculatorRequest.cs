using System.ComponentModel.DataAnnotations;

namespace B3.CDB.API.ViewModel
{
    public class CdbCalculatorRequest
    {
        [Required(ErrorMessage = "Term is required")]
        [Range(1, int.MaxValue, ErrorMessage ="The value cannot be less than 1.")]
        private int _term;

        [Required(ErrorMessage = "Amount value is required")]
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "Insert a valid amount value.")]
        private decimal _initialAmount;


        public int Term { get => _term; set => _term = value; }
        public decimal InitialAmount { get => _initialAmount; set => _initialAmount = value; }
    }
}