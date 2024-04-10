class Hunter : Character
{
    private int health = 100;
    private int attackHigh = 15;
    private int attackLow = 8;
    public override int GetHealth()
    {
        return health;
    }
    public override int GetAttackHigh()
    {
        return attackHigh;
    }
    public override int GetAttackLow()
    {
        return attackLow;
    }
}