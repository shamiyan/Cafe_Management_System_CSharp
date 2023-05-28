using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_management
{
    class Cafe
    {
        public Cafe()
        {
            newLatte_coffee = 0.0;
            newesprosson = 0.0;
            newicapp_coff = 0.0;
            newvale_coff = 0.0;
            newAfri_coff = 0.0;
            newAmer_coff = 0.0;
            newCapp_coff = 0.0;
            newicapp_coff = 0.0;

            newc_Cake = 0.0;
            newvl_Cake = 0.0;
            newbf_Cake = 0.0;
            newcb_Cake = 0.0;
            newcl_Cake = 0.0;
            newck_Cake = 0.0;
            newcc_Cake = 0.0;
            newcq_Cake = 0.0;
        }

        public Cafe(double Latte_coffee,double esprosson,double IcedLatte, double vale_coff,double Afri_coff,double Amer_coff,double Capp_coff,double icapp_coff,double c_Cake,
            double vl_Cake,double bf_Cake,double cb_Cake,double cl_Cake, double ck_Cake, double cc_Cake,double cq_Cake)
        {
            newLatte_coffee = Latte_coffee;
            newesprosson = esprosson;
            newIcedLatte = icapp_coff;
            newvale_coff = vale_coff;
            newAfri_coff = Afri_coff;
            newAmer_coff = Amer_coff;
            newCapp_coff = Capp_coff;
            newicapp_coff = icapp_coff;

            newc_Cake = c_Cake;
            newvl_Cake = vl_Cake;
            newbf_Cake = bf_Cake;
            newcb_Cake = cb_Cake;
            newcl_Cake = cl_Cake;
            newck_Cake = ck_Cake;
            newcc_Cake = cc_Cake;
            newcq_Cake = cq_Cake;
        }

        public double getLatte_coffee()
        {
            return newLatte_coffee;
        }
        public double getesprosson()
        {
            return newesprosson;
        }
        public double getIcedLatte()
        {
            return newIcedLatte;
        }
        public double getvale_coff()
        {
            return newvale_coff;
        }
        public double getAfri_coff()
        {
            return newAfri_coff;
        }
        public double getAmer_coff()
        {
            return newAmer_coff;
        }
        public double getCapp_coff()
        {
            return newCapp_coff;
        }
        public double geticapp_coff()
        {
            return newicapp_coff;
        }

        public double getc_Cake()
        {
            return newc_Cake;
        }
        public double getvl_Cake()
        {
            return newvl_Cake;
        }
        public double getbf_Cake()
        {
            return newbf_Cake;
        }
        public double getcb_Cake()
        {
            return newcb_Cake;
        }
        public double getcl_Cake()
        {
            return newcl_Cake;
        }
        public double getck_Cake()
        {
            return newck_Cake;
        }
        public double getcc_Cake()
        {
            return newcc_Cake;
        }
        public double getcq_Cake()
        {
            return newcq_Cake;
        }

        private double newLatte_coffee;
        private double newesprosson;
        private double newIcedLatte;
        private double newvale_coff;
        private double newAfri_coff;
        private double newAmer_coff;
        private double newCapp_coff;
        private double newicapp_coff;

        private double newc_Cake;
        private double newvl_Cake;
        private double newbf_Cake;
        private double newcb_Cake;
        private double newcl_Cake;
        private double newck_Cake;
        private double newcc_Cake;
        private double newcq_Cake;
    }
}
