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
    public DateTime TripStart { get; set; }
    public DateTime TripEnd { get; set; }
    public string Description { get; set; }
    public string Destination { get; set; }
    public decimal BasePrice { get; set; }
    public string ClassId { get; set; }
}