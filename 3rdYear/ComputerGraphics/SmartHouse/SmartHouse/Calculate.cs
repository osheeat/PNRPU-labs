using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public class Calculate
    {
        public const double step = 0.1;
        public double room1_t;
        public double room2_t;
        public double room3_t;

        public double room1t_proiz;
        public double room2t_proiz;
        public double room3t_proiz;

        public double room1t_change;
        public double room2t_change;
        public double room3t_change;

        public double out_t;
        public double reg_t;

        public double k1;
        public double k2;
        public double k3;
        public double k4;
        public double k5;
        public double k6;

        public void f()
        {
            room1t_proiz = k1 * (room2_t - room1_t) + k4 * (room3_t - room1_t) + k5 * (out_t - room1_t) + k3 * (reg_t - room1_t);
            room2t_proiz = k1 * (room1_t - room2_t) + k2 * (out_t - room2_t) + k3 * (reg_t - room2_t);
            room3t_proiz = k4 * (room1_t - room3_t) + k6 * (out_t - room3_t) + k3 * (reg_t - room3_t);

            room1t_change = room1t_proiz * step;
            room2t_change = room2t_proiz * step;
            room3t_change = room3t_proiz * step;

            room1_t = room1_t + room1t_change;
            room2_t = room2_t + room2t_change;
            room3_t = room3_t + room3t_change;
        }
    }   
}
