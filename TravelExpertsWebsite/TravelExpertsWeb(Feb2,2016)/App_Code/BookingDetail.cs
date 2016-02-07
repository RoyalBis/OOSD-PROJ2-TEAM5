using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// <Code Comment>
// Author: Kevin Liao
// Date: Jan 28, 2016
// Class: OOSD Oct 2015
// Description: Entity class for BookingDetails Table
// PS: Authors' legal names -> Anne = Qurat-ul-ain, Kevin = Sheng
// </Comment>

public class BookingDetail
{
    public BookingDetail() { }
    public int BookingId { get; set; }
    public string TripStart { get; set; }
    public string TripEnd { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public string BasePrice { get; set; }
    public string ClassId { get; set; }
}