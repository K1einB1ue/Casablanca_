﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllContainer
{
    //// <summary>
    /// 第一个数为背包大小,第二个为Type,第三个为ID
    /// </summary>

    [Item(ItemType.Container, 0)]
    public class PlayerStaticBag : ContainerStatic 
    {
        /*
        static PlayerStaticBag() {
            Items.AddGen<PlayerStaticBag>(ItemType.Container, 0);
        }
        */
        public PlayerStaticBag() : base(7) { }
        public override void update() {
            /*
            timer1.TimeingLoop(this.Use1, ref this.Trigger1);
            timer2.TimeingLoop(this.Use2, ref this.Trigger2);
            timer3.TimeingLoop(this.Use3, ref this.Trigger3);
            timer4.TimeingLoop(this.Use4, ref this.Trigger4);
            timer5.TimeingLoop(this.Use5, ref this.Trigger5);
            */
            this.CheckEmpty();
        }

    }

    [Item(ItemType.Container, 1)]
    public class NormalBackpack :ContainerStatic
    {
        /*
        static NormalBackpack() {
            Items.AddGen<NormalBackpack>(ItemType.Container, 1);
        }
        */
        public NormalBackpack() : base(5) { }
        public override void Use6(Item item,out Item itemoutEX) {
            ToolComponent.contain(this, item, out Item itemoutEx, 
                () => { Debug.Log("不错的一个背包"); }, 
                () => { Debug.Log("或许它还能装下:"+((Container)this).ItemBlockRemain().ToString()+"格物品."); }, 
                () => { Debug.Log("'容纳'自身的'容纳性'吗?"); }
                );
            itemoutEX = itemoutEx;
        }
    }
}


