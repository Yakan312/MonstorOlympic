using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Syndicate
{
    /// <summary>
    /// ボスの指令カード
    /// </summary>
    public class MOrdersCard : Syndicate.MCardBase
    {
        // field
        string name;            // カードの名前
        public　string Name => name;
        string effectDesc;      // カードの効果の説明
        public string EffectDesc => effectDesc;
        bool isPlayable;        // カードがプレイ可能かどうか
        public bool IsPlayable => isPlayable;
        bool isDiscardable;     // カードが捨てられるかどうか
        public bool IsDisDiscardable => isDiscardable;
        bool isDiscarded;       // カードが捨てられたかどうか
        public bool IsDiscarded => isDiscarded;
        bool isSelectable;      // カードが選択可能かどうか
        public bool IsSelectable => isSelectable;
        bool isPlaying;         // カードがプレイ中かどうか
        public bool IsPlaying => isPlaying;
        int effectSlctCnt;      // 効果の選択肢の数
        public int EffectSlcCnt => effectSlctCnt;
        int effectSlcNum;       // 選択した効果の番号
        public int EffectSlcNum => effectSlcNum;

        // property

        // constructor
        public MOrdersCard(int id,int type,int uid) : base(id, type, uid)
        {

        }

        // public method


        // private method

    }
}
