using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseNET
{
    public class PIDController
    {
        private double setpoint;
        private double kP;
        private double kI;
        private double kD;
        private double previousError;
        private double integral;
        private double output;

        public PIDController(double setpoint, double kP, double kI, double kD)
        {
            this.setpoint = setpoint;
            this.kP = kP;
            this.kI = kI;
            this.kD = kD;
            this.previousError = 0;
            this.integral = 0;
            this.output = 0;
        }

        public double Compute(double input, double time)
        {
            double error = setpoint - input;
            integral += error * time;
            double derivative = (error - previousError) / time;
            output = kP * error + kI * integral + kD * derivative;
            previousError = error;
            return output;
        }

        public void SetSetpoint(double setpoint)
        {
            this.setpoint = setpoint;
        }

        public void SetTunings(double kP, double kI, double kD)
        {
            this.kP = kP;
            this.kI = kI;
            this.kD = kD;
        }

        public void Reset()
        {
            previousError = 0;
            integral = 0;
            output = 0;
        }
    }
}
