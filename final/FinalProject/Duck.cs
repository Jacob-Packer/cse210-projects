class Duck : Character
{
    private int health = 100;
    private int attackHigh = 20;
    private int attackLow = 10;
    
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