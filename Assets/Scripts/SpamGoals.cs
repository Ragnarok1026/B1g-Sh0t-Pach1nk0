using System.Runtime.CompilerServices;
using UnityEngine;

public class SpamGoals : MonoBehaviour
{
    public int KromerValue = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pepis"))
        {


            KR0M3RKounter.instance.AddKromer(KromerValue);
            int kromerToAdd = 0;
            switch (KromerValue)
            {
                case 50:
                    kromerToAdd = -50;
                    break;

                case 5:
                    kromerToAdd = 5;
                    break;

                case 10:
                    kromerToAdd = 10;
                    break;

                case 100:
                    kromerToAdd = 100;
                    break;
            }


            KR0M3RKounter.instance.AddKromer(kromerToAdd);
        }
    }
}


