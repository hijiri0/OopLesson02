class BmiCalculator
{
    // 身長はcm単位で、体重はkg単位で渡してもらう
    public double GetBmi(double height, double weight)
    {
        var metersTall = height / 100.0;
        var bmi = weight / (metersTall * metersTall);
        return bmi;
    }
}
