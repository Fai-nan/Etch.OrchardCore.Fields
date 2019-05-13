﻿using Fluid;
using Microsoft.Extensions.DependencyInjection;
using Etch.OrchardCore.Fields.ResponsiveMedia.Drivers;
using Etch.OrchardCore.Fields.ResponsiveMedia.Fields;
using Etch.OrchardCore.Fields.ResponsiveMedia.Settings;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Modules;

namespace Etch.OrchardCore.Fields.ResponsiveMedia
{
    [Feature("Etch.OrchardCore.Fields.ResponsiveMedia")]
    public class Startup : StartupBase
    {
        static Startup()
        {
            TemplateContext.GlobalMemberAccessStrategy.Register<ResponsiveMediaField>();
        }

        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ContentField, ResponsiveMediaField>();
            services.AddScoped<IContentFieldDisplayDriver, ResponsiveMediaFieldDisplayDriver>();
            services.AddScoped<IContentPartFieldDefinitionDisplayDriver, ResponsiveMediaFieldSettingsDriver>();
        }
    }
}