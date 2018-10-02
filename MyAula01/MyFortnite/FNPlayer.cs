using System;
namespace MyFortnite
{
    public class FNPlayer
    {
        string EquipWeapon;
        double HitPoints,Shield;

        public void Atack(FNPlayer enemy)
        {
            enermy.TakeDamage(10);
                          
        }

        public void TakeDamage(double damage)
        {
            if (Shield > 0)
            {
                Shield -= damage;
                if (shield < 0)
                {
                    Shield = 0;
                }

            }
        }
            
    }
}
