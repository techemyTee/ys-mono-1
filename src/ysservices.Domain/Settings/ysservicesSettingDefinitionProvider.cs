using Volo.Abp.Settings;

namespace ysservices.Settings;

public class ysservicesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ysservicesSettings.MySetting1));
    }
}
