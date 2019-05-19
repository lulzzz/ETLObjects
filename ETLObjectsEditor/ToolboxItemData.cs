﻿using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ETLObjectsEditor
{
    [Serializable()]
    public class ToolboxItemData : ISerializable
    {
        #region Fields
        private string content;
        #endregion Fields


        #region Constructors
        /// <summary>
        /// Overloaded constructor.
        /// </summary>
        /// <param name="sentence">Sentence value.</param>
        public ToolboxItemData(string sentence)
        {
            content = sentence;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Gets the ToolboxItemData Content.
        /// </summary>
        public string Content
        {
            get { return content; }
        }
        #endregion Properties

        internal ToolboxItemData(SerializationInfo info, StreamingContext context)
        {
            content = info.GetValue("Content", typeof(string)) as string;
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                info.AddValue("Content", Content);
            }
        }
    }
}
