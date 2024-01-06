using System.Collections;
using System.Collections.Generic;
using Unity.Engine

public class Temperature : Monobehaviour
{
    public Health Health;
    public int playerdamage = 2;
    public float TemperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezeSpeed = 0.05f
    public float freezedamageTimer = 1;
    public float freezedamagedelay = 2;

    void Update()
    {
        TemperatureCurrent -= freezeSpeed * Time.deltatime}:
            
              if (TemperatureCurrent <= TemperatureCritical)
            {
                     if (freezedamageTimer <= 0)
                     {
                            health.TakeDamage(PlayerDamage):
                            freezedamageTimer += freezedamagedelay:
                     }
                     else
                     {
                            freezedamageTimer -= Time.deltatime;
                     }
            }
    }
}