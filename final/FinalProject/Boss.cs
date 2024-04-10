class Boss : Character
{
    private int health = 250;
    private int attackHigh = 1;
    private int attackLow = 1;
    
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