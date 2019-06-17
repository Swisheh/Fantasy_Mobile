using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {

    private SpriteRenderer equippedWeapon;
    private int weaponType;
    // #1 = Sword
    // #2 = Axe
    // #3 = Claw

    // Use this for initialization
    void Start () {
        equippedWeapon = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
	   if (weaponType == 3)
        {
            equippedWeapon.sortingOrder = 5;
        } else
        {
            equippedWeapon.sortingOrder = 4;
        }
	}

    public void weaponSwap(string weapon)
    {
        equippedWeapon.sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>("Assets/Weapons/" + weapon + ".png");
    }

    public void changeType(int type)
    {
        int orinalType = weaponType;
        weaponType = type;
        
        if (weaponType == 3 && weaponType != orinalType)
        {
            equippedWeapon.transform.Rotate(Vector3.forward * 90);
        }
        else if (orinalType == 3 && weaponType != 3)
        {
            equippedWeapon.transform.Rotate(Vector3.forward * -90);
        }
    }
}
