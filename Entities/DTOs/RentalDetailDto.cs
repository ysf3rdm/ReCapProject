﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime RentDate { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
