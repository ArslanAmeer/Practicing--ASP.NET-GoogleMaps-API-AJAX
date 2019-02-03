using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practicing_AJAX_GoogleApi_ClickEvents.Models
{
    public class GoogleMapCord
    {
        [Key]
        public int Id { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}