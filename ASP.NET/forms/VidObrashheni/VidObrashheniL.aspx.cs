﻿/*flexberryautogenerated="true"*/
namespace IIS.Горводоканал
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ВидОбращениL : BaseListForm<ВидОбращени>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ВидОбращениL() : base(ВидОбращени.Views.ВидОбращениL)
        {
            EditPage = ВидОбращениE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/VidObrashheni/VidObrashheniL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
