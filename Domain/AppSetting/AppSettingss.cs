using Microsoft.Extensions.Configuration;

namespace Domain.AppSetting;

public  class AppSettingss
{
    public IConfigurationSection ConnectionString { get; set; }

    public AppSettingss(IConfiguration configuration)
    {
        this.ConnectionString = configuration.GetSection("ConnectionString");
    }
}