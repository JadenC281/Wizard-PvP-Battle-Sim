using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IHittable_inherited : MonoBehaviour, IHitable
{

   [SerializeField] private enum ObjectType {

        nullify,
        Player,
        Breakable

    }
    [SerializeField] ObjectType Type;


    public void GotHit(GameObject ObjectThatHitMe) {

        if(Type == ObjectType.nullify) {

            Destroy(ObjectThatHitMe);
            print("Spell  Nullable obj got hit");

        }    
        
        else if(Type == ObjectType.Player) {

            print("Player got hit");

        }   
        
        else if(Type == ObjectType.Breakable) {

            print("Breakable got hit");

        }





    }



}
