using Microsoft.EntityFrameworkCore;
using MyVideo.Demo.Models.VideoMetadatas;

namespace MyVideo.Demo.Brokers.Storages;

internal partial class StorageBroker_VideoMetadatas
{
    public DbSet<VideoMetadatas> VideoMetadatas { get; set; }
}