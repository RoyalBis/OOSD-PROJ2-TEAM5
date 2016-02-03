using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookingDetail
/// </summary>
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