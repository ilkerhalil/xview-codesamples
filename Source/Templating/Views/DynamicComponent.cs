﻿using Chimote.Tridion.Templating.Intranet.Common;

using Tridion.ContentManager.CommunicationManagement;
using Tridion.ContentManager.ContentManagement;

namespace Chimote.Tridion.Templating.Intranet.Views
{
    public abstract class DynamicComponentView : ComponentView
    {
        /// <summary>
        /// Override this method to share Context.PageScope data with a PT and  all subsequent
        /// CTs on the same page. This method is call by a PT rendition prior to the call to
        /// Context.Engine.RenderComponentPresentation(TcmUri componentUri, TcmUri componentTemplateUri).
        /// </summary>
        /// <param name="component">Component.</param>
        /// <param name="template">ComponentTemplate.</param>
        public virtual void SetPageScopeData(Component component, ComponentTemplate template)
        {
            DebugGuard.Requires(this.Context.IsPageContext);
        }

        protected override void CheckPreconditions()
        {
            Guard.Requires(this.Context.IsDynamicTemplate(this.Context.Template));
        }
    }
}