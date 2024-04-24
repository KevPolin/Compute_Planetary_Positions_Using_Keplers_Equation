Celestial Programming : Compute Planet Positions Using Kepler's Equation

This is an implementation of the algorithm described in Chapter 8 of the Explanatory Supplement to the Astronomical Almanac 3rd ed P340.
Two sets of elements are provided, and they are accurate for different intervals. The first set is valid for 1800-2050, and the worst 
case accuracy is for Saturn at about 10 arc minutes. Most others are under 1 arcmin. The second set is valid for 3000BC to 3000AD, 
and has a worst case accuracy (for Uranus) of about half a degree. Most others are on the order of 1 arc minute. See table 8.10 in 
the Explanatory Supplement for full accuracy details.

You'll notice that each planet has 12 elements rather than the nomral 6 Kelperian elements. A pure Kelperian element solve looses 
accuracy rather quickly due to purturation effects from other planets. So the authors of this routine have provided an additional 
6 elements which are corrections to the Kelperian elements based on time since Jan 1 2000. The corrections were specifically fit to 
the specified time periods, so they are considered invalid outside of that time period.

An explanation of the method used is also available as Keperian Elements for Approximat Positions of the Major Planets. A more 
general overview is at SSD JPL.

Since this routine contains only elements for the Earth-Moon Barycenter, and not the Earth or the Moon, this example uses the 
Earth-Moon Barycenter as the location for the observer. Due to parallax, the positions will be off slightly from those generated 
for a Geocentric or Topocentric observer. Since the planets are far away, this error will be insignificant for many purposes.

Due to it's compactness, and relatively quick computation, this method can be quite useful in a lot of applications where the high
memory footprint, and number of computations of other ephemeris methods are impractical or unnecessary.
