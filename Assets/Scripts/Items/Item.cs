﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    [SerializeField]
    private Sprite icon;

    [SerializeField]
    private int stackSize;

    private SlotScript slot;

    public Sprite MyIcon { 
        get
        {
            return icon;
        }
     }

    public int StackSize {
        get
        {
            return stackSize;
        } 
    }

   public BagScript MyBagScript{ get; set; }

    public SlotScript MySlot 
    { 
        get
        {
            return slot;
        } 
        set
        {
            slot = value;
        }
    }

    public void Remove()
    {
        if(MySlot != null)
        {
            MySlot.RemoveItem(this);
        }
    }
}
