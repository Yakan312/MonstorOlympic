using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Syndicate
{
    /// <summary>
    /// カード基底クラス
    /// </summary>
    public class MCardBase : Syndicate.InGameContents.ICard
    {
        public MCardBase(int id, int type, int uid)
        {
            cardId = id;
            cardType = type;
            uniId = uid;
        }

        // Property
        public int CardID => cardId;
        public int CardType => cardType;
        public int UniID => uniId;

        // Field
        protected int cardId;       // カードのID
        protected int cardType;     // カードの種類
        protected int uniId;        // カードのユニークID

    }
}