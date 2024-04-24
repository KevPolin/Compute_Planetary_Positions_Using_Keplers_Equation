using System;

class Program
{

    //jd = 2460424.6280036457
    static void Main(string[] args)
    {
        //public double[] ComputePlanetPosition(double jd, double[] elements, double[] rates, double[] extraTerms)
        double[] result = ComputePlanetPosition(2460424.6280036457, data1800to2050, data3000BCto3000AD, extraTerms);
        //ShowReviews(5915530);
    }

    string[] planetNames = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto", "Sun" };

    public static double[][] data1800to2050 = new double[][]
    {
        // Mercury
        new double[]
        {
            0.38709927, 0.20563593, 7.00497902, 252.25032350, 77.45779628, 48.33076593
        },
        new double[]
        {
            0.00000037, 0.00001906, -0.00594749, 149472.67411175, 0.16047689, -0.12534081
        },
        // Venus
        new double[]
        {
            0.72333566, 0.00677672, 3.39467605, 181.97909950, 131.60246718, 76.67984255
        },
        new double[]
        {
            0.00000390, -0.00004107, -0.00078890, 58517.81538729, 0.00268329, -0.27769418
        },
        // EM Bary
        new double[]
        {
            1.00000261, 0.01671123, -0.00001531, 100.46457166, 102.93768193, 0.0
        },
        new double[]
        {
            0.00000562, -0.00004392, -0.01294668, 35999.37244981, 0.32327364, 0.0
        },
        // Mars
        new double[]
        {
            1.52371034, 0.09339410, 1.84969142, -4.55343205, -23.94362959, 49.55953891
        },
        new double[]
        {
            0.00001847, 0.00007882, -0.00813131, 19140.30268499, 0.44441088, -0.29257343
        },
        // Jupiter
        new double[]
        {
            5.20288700, 0.04838624, 1.30439695, 34.39644051, 14.72847983, 100.47390909
        },
        new double[]
        {
            -0.00011607, -0.00013253, -0.00183714, 3034.74612775, 0.21252668, 0.20469106
        },
        // Saturn
        new double[]
        {
            9.53667594, 0.05386179, 2.48599187, 49.95424423, 92.59887831, 113.66242448
        },
        new double[]
        {
            -0.00125060, -0.00050991, 0.00193609, 1222.49362201, -0.41897216, -0.28867794
        },
        // Uranus
        new double[]
        {
            19.18916464, 0.04725744, 0.77263783, 313.23810451, 170.95427630, 74.01692503
        },
        new double[]
        {
            -0.00196176, -0.00004397, -0.00242939, 428.48202785, 0.40805281, 0.04240589
        },
        // Neptune
        new double[]
        {
            30.06992276, 0.00859048, 1.77004347, -55.12002969, 44.96476227, 131.78422574
        },
        new double[]
        {
            0.00026291, 0.00005105, 0.00035372, 218.45945325, -0.32241464, -0.00508664
        },
        // Pluto
        new double[]
        {
            39.48211675, 0.24882730, 17.14001206, 238.92903833, 224.06891629, 110.30393684
        },
        new double[]
        {
            -0.00031596, 0.00005170, 0.00004818, 145.20780515, -0.04062942, -0.01183482
        }
    };

    //    public static double[][] data1800to2050 = new double[][]
    public static double[][] data3000BCto3000AD = new double[][]
    {
        // Mercury
        new double[] { 0.38709843, 0.20563661, 7.00559432, 252.25166724, 77.45771895, 48.33961819 },
        new double[] { 0.00000000, 0.00002123, -0.00590158, 149472.67486623, 0.15940013, -0.12214182 },
        // Venus
        new double[] { 0.72332102, 0.00676399, 3.39777545, 181.97970850, 131.76755713, 76.67261496 },
        new double[] { -0.00000026, -0.00005107, 0.00043494, 58517.81560260, 0.05679648, -0.27274174 },
        // Earth-Moon Barycenter
        new double[] { 1.00000018, 0.01673163, -0.00054346, 100.46691572, 102.93005885, -5.11260389 },
        new double[] { -0.00000003, -0.00003661, -0.01337178, 35999.37306329, 0.31795260, -0.24123856 },
        // Mars
        new double[] { 1.52371243, 0.09336511, 1.85181869, -4.56813164, -23.91744784, 49.71320984 },
        new double[] { 0.00000097, 0.00009149, -0.00724757, 19140.29934243, 0.45223625, -0.26852431 },
        // Jupiter
        new double[] { 5.20248019, 0.04853590, 1.29861416, 34.33479152, 14.27495244, 100.29282654 },
        new double[] { -0.00002864, 0.00018026, -0.00322699, 3034.90371757, 0.18199196, 0.13024619 },
        // Saturn
        new double[] { 9.54149883, 0.05550825, 2.49424102, 50.07571329, 92.86136063, 113.63998702 },
        new double[] { -0.00003065, -0.00032044, 0.00451969, 1222.11494724, 0.54179478, -0.25015002 },
        // Uranus
        new double[] { 19.18797948, 0.04685740, 0.77298127, 314.20276625, 172.43404441, 73.96250215 },
        new double[] { -0.00020455, -0.00001550, -0.00180155, 428.49512595, 0.09266985, 0.05739699 },
        // Neptune
        new double[] { 30.06952752, 0.00895439, 1.77005520, 304.22289287, 46.68158724, 131.78635853 },
        new double[] { 0.00006447, 0.00000818, 0.00022400, 218.46515314, 0.01009938, -0.00606302 },
        // Pluto
        new double[] { 39.48686035, 0.24885238, 17.14104260, 238.96535011, 224.09702598, 110.30167986 },
        new double[] { 0.00449751, 0.00006016, 0.00000501, 145.18042903, -0.00968827, -0.00809981 }
};

    //            b             c             s            f 
    public static double[][] extraTerms = new double[][]
    {
    new double[] {-0.00012452, 0.06064060, -0.35635438, 38.35125000}, // Jupiter
    new double[] {0.00025899, -0.13434469, 0.87320147, 38.35125000}, // Saturn
    new double[] {0.00058331, -0.97731848, 0.17689245, 7.67025000}, // Uranus
    new double[] {-0.00041348, 0.68346318, -0.10162547, 7.67025000}, // Neptune
    new double[] {-0.01262724, 0, 0, 0} // Pluto
    };

    public double[] ComputePlanetPosition(double jd, double[][] elements, double[][] rates, double[][] extraTerms)
    {
        double toRad = Math.PI / 180;
        //Algorithm from Explanatory Supplement to the Astronomical Almanac ch8 P340
        //Step 1:
        double T = (jd - 2451545.0) / 36525;
        double a = elements[0] + rates[0] * T;
        double e = elements[1] + rates[1] * T;
        double I = elements[2] + rates[2] * T;
        double L = elements[3] + rates[3] * T;
        double w = elements[4] + rates[4] * T;
        double O = elements[5] + rates[5] * T;

        //Step 2:
        double ww = w - O;
        double M = L - w;
        if (extraTerms.Length > 0)
        {
            double b = extraTerms[0];
            double c = extraTerms[1];
            double s = extraTerms[2];
            double f = extraTerms[3];
            M = L - w + b * T * T + c * Math.Cos(f * T * toRad) + s * Math.Sin(f * T * toRad);
        }
        while (M > 180) { M -= 360; }

        double E = M + 57.29578 * e * Math.Sin(M * toRad);
        double dE = 1;
        int n = 0;
        while (Math.Abs(dE) > 1e-7 && n < 10)
        {
            dE = SolveKepler(M, e, E);
            E += dE;
            n++;
        }

        //Step 4:
        double xp = a * (Math.Cos(E * toRad) - e);
        double yp = a * Math.Sqrt(1 - e * e) * Math.Sin(E * toRad);
        double zp = 0;

        //Step 5:
        a *= toRad; e *= toRad; I *= toRad; L *= toRad; ww *= toRad; O *= toRad;
        double xecl = (Math.Cos(ww) * Math.Cos(O) - Math.Sin(ww) * Math.Sin(O) * Math.Cos(I)) * xp + (-Math.Sin(ww) * Math.Cos(O) - Math.Cos(ww) * Math.Sin(O) * Math.Cos(I)) * yp;
        double yecl = (Math.Cos(ww) * Math.Sin(O) + Math.Sin(ww) * Math.Cos(O) * Math.Cos(I)) * xp + (-Math.Sin(ww) * Math.Sin(O) + Math.Cos(ww) * Math.Cos(O) * Math.Cos(I)) * yp;
        double zecl = (Math.Sin(ww) * Math.Sin(I)) * xp + (Math.Cos(ww) * Math.Sin(I)) * yp;

        //Step 6:
        double eps = 23.43928 * toRad;

        double x = xecl;
        double y = Math.Cos(eps) * yecl - Math.Sin(eps) * zecl;
        double z = Math.Sin(eps) * yecl + Math.Cos(eps) * zecl;

        return new double[] { x, y, z };
    }

    // Function to solve Kepler's equation
    public double SolveKepler(double M, double e, double E)
    {
        const double toRad = Math.PI / 180;

        double dM = M - (E - e / toRad * Math.Sin(E * toRad));
        double dE = dM / (1 - e * Math.Cos(E * toRad));
        return dE;
    }
}