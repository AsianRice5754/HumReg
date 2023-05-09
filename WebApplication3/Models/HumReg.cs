using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;


namespace MainApplicaion.Models
{
    
    public class HumReg
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Serial { get; set; }
        public string? MachineName { get; set; }
        public string? ShipDate { get; set; }
        public string? InstallDate { get; set; }
        public string? UpsManufacturer { get; set; }
        public string? UpsModel { get; set; }
        public string? UpsSerial { get; set; }
        //add ups manufacturer, ups model, and ups serial





        public string? Customer { get; set; }
        public string? CustomerContact { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerUnit { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerState { get; set; }
        public string? CustomerZip { get; set; }




        public string? Provider { get; set; }
    
        public string? ProviderPhone { get; set; }
        public string? ProviderEmail { get; set; }
        public string? ProviderAddress { get; set; }
        public string? ProviderUnit { get; set; }
        public string? ProviderCity { get; set; }
        public string? ProviderState { get; set; }
        public string? ProviderZip { get; set; }




        public string? Technician { get; set; }
        public string? TechnicianPhone { get; set; }
        public string? TechnicianEmail { get; set; }







    







    }
}
