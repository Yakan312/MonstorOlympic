using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Syndicate
{
    /// <summary>
    /// �C���Q�[�����̋K��l��interface������
    /// </summary>
    public static class InGameContents
    {
        #region Default Values
        #endregion

        #region interface
        /// <summary>
        /// �J�[�h����interface
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