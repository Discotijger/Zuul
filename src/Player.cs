class Player{
    public Room CurrentRoom {get; set;}
    public int Health { get; set; }

    public Player(){
        CurrentRoom = null;
        Health = 100;
    }

    public int Damage(int amount)
    {
        Health -= amount;
        return Health;
    }
    //public int Heal()
    //{

    //}
    //public int IsAlive()
    //{
    //    if (health <= 0)
    //    {
    //        Game.wantToQuit = true;
    //    }
    //}
}