using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPayment.Models
{
    public class Payment
    {
       public int ID { get; set; }

       [Display(Name = "Pregunta")]
       public string Pago { get; set; } 

       [Display(Name = "Fecha Respuesta")]
       [DataType(DataType.Date)]
       public DateTime ReleaseDate { get; set; } = DateTime.Today;

       //[Display(Name = "Fecha de Pregunta")]
       //[DataType(DataType.Date)]
       //public DateTime AskReleaseDate { get; set; } = DateTime.Today;

       [Display(Name = "Respuesta")]
       public string Genre { get; set;}

       [Display(Name = "Descripcion de pregunta")]
       public string Price { get; set;}
    }


    //public class AskUpdate
    //{
       //public int ID { get; set; }

       //[Display(Name = "Fecha de Pregunta")]
       //[DataType(DataType.Date)]
       //public DateTime AskReleaseDate { get; set; } = DateTime.Today;
    //}
}