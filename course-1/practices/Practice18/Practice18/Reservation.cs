using System;

public class Reservation
{
	public Book ReservationBook { get; set; }
	public DateTime ReservationDate { get; set; }
	public int Period { get; set; }

	public Reservation(Book book, DateTime reservationdate, int period)
	{
		ReservationBook = book;
        ReservationDate = reservationdate;
		Period = period;
	}
}
