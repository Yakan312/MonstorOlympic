using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Syndicate
{
    /// <summary>
    /// インゲーム内の規定値やinterfaceを書く
    /// </summary>
    public static class InGameContents
    {
        #region Default Values
        #endregion

        #region interface
        /// <summary>
        /// カード共通interface
        /// </summary>
        public interface ICard
        {
            int CardID { get;}
            int CardType { get;}
            bool IsFacedown { get; }
        }
        #endregion
        
        #region MasterData

        #endregion
    }
}