﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Collections.Generic;

namespace OpenCvSharp.Blob.Old
{
	/// <summary>
    /// Chain code.
    /// </summary>
    public class CvChainCodes : CvObject, ICollection<CvChainCode>
    {
        #region Init and Disposal
#if LANG_JP
        /// <summary>
        /// ポインタから初期化
        /// </summary>
        /// <param name="ptr">CvChainCodes*</param>
#else
        /// <summary>
        /// Initializes from pointer
        /// </summary>
        /// <param name="ptr">CvChainCodes*</param>
#endif
        public CvChainCodes(IntPtr ptr)
            : base(ptr)
        {
        }
#if LANG_JP
        /// <summary>
        /// ポインタから初期化
        /// </summary>
        /// <param name="ptr">CvChainCodes*</param>
#else
        /// <summary>
        /// Initializes from pointer
        /// </summary>
        /// <param name="ptr">CvChainCodes*</param>
#endif
        public static CvChainCodes FromPtr(IntPtr ptr)
        {
            return new CvChainCodes(ptr);
        }
        #endregion

        #region ICollection<CvChainCode> Members
#if LANG_JP
        /// <summary>
        /// このコレクション に項目を追加します。
        /// </summary>
        /// <param name="item">このコレクション に追加するオブジェクト。</param>
#else
        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">The object to add to the collection.</param>
#endif
        public void Add(CvChainCode item)
        {
            CvBlobInvoke.CvChainCodes_PushBack(ptr, item);
        }
#if LANG_JP
        /// <summary>
        /// コレクション からすべての項目を削除します。
        /// </summary>
#else
        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
#endif
        public void Clear()
        {
            CvBlobInvoke.CvChainCodes_Clear(ptr);
        }
#if LANG_JP
        /// <summary>
        /// このコレクション に特定の値が格納されているかどうかを判断します。
        /// </summary>
        /// <param name="item">このコレクション 内で検索するオブジェクト。</param>
        /// <returns>item が このコレクション に存在する場合は true。それ以外の場合は false。</returns>
#else
        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns> true if item is found in the collection; otherwise, false.</returns>
#endif
        public bool Contains(CvChainCode item)
        {
            return CvBlobInvoke.CvChainCodes_Contains(ptr, item);
        }
#if LANG_JP
        /// <summary>
        /// このコレクション の要素を Array にコピーします。Array の特定のインデックスからコピーが開始されます。
        /// </summary>
        /// <param name="array">このコレクション から要素がコピーされる 1 次元の Array。Array には、0 から始まるインデックス番号が必要です。</param>
        /// <param name="arrayIndex">コピーの開始位置となる、array の 0 から始まるインデックス番号。</param>
#else
        /// <summary>
        /// Copies the elements of the collection to an Array, starting at a particular Array index.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements copied from collection. The Array must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
#endif
        public void CopyTo(CvChainCode[] array, int arrayIndex)
        {
            CvBlobInvoke.CvChainCodes_CopyTo(ptr, array, arrayIndex);
        }
#if LANG_JP
        /// <summary>
        /// このコレクション に格納されている要素の数を取得します。
        /// </summary>
#else
        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
#endif
        public int Count
        {
            get
            {
                return CvBlobInvoke.CvChainCodes_Count(ptr);
            }
        }
#if LANG_JP
        /// <summary>
        /// このコレクション が読み取り専用かどうかを示す値を取得します。
        /// </summary>
#else
        /// <summary>
        /// Gets a value indicating whether the collectio is read-only.
        /// </summary>
#endif
        public bool IsReadOnly
        {
            get { return false; }
        }
#if LANG_JP
        /// <summary>
        /// コレクション 内で最初に見つかった特定のオブジェクトを削除します。
        /// </summary>
        /// <param name="item">コレクションから削除するオブジェクト。</param>
        /// <returns>item がコレクション から正常に削除された場合は true。それ以外の場合は false。</returns>
#else
        /// <summary>
        /// Removes the first occurrence of a specific object from the collection.
        /// </summary>
        /// <param name="item">The object to remove from the collection.</param>
        /// <returns>true if item was successfully removed from the collection; otherwise, false.</returns>
#endif
        public bool Remove(CvChainCode item)
        {
            return CvBlobInvoke.CvChainCodes_Remove(ptr, item);
        }
        #endregion
        #region IEnumerable<CvChainCode> Members
#if LANG_JP
		/// <summary>
        /// コレクションを反復処理する列挙子を返します。
        /// </summary>
#else
        /// <summary>
        /// Returns an enumerator that iterates through a collection. 
        /// </summary>
#endif
        public IEnumerator<CvChainCode> GetEnumerator()
        {
            CvChainCode[] array = new CvChainCode[Count];
            CopyTo(array, 0);

            foreach (CvChainCode item in array)
            {
                yield return item;
            }
        }
#if LANG_JP
		/// <summary>
        /// コレクションを反復処理する列挙子を返します。
        /// </summary>
#else
        /// <summary>
        /// Returns an enumerator that iterates through a collection. 
        /// </summary>
#endif
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
