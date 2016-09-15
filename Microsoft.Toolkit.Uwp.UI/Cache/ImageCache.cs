﻿using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Toolkit.Uwp.UI
{
    /// <summary>
    /// Provides methods and tools to cache files in a folder
    /// </summary>
    public class ImageCache : CacheBase<BitmapImage>
    {
        static ImageCache()
        {
            ImageCacheInstance = new ImageCache();
        }

        /// <summary>
        /// Gets instance of FileCache. Exposing it as static property will allow inhertance and polymorphism while
        /// exposing the underlying object and its functionality through this property,
        /// </summary>
        public static ImageCache ImageCacheInstance { get; private set; }

        /// <summary>
        /// Cache specific hooks to proccess items from http response
        /// </summary>
        /// <param name="stream">inpupt stream</param>
        /// <returns>awaitable task</returns>
        protected override async Task<BitmapImage> InitializeTypeAsync(IRandomAccessStream stream)
        {
            // nothing to do in this instance;
            BitmapImage image = new BitmapImage();
            await image.SetSourceAsync(stream);

            return image;
        }

        /// <summary>
        /// Cache specific hooks to proccess items from http response
        /// </summary>
        /// <param name="baseFile">storage file</param>
        /// <returns>awaitable task</returns>
        protected override async Task<BitmapImage> InitializeTypeAsync(StorageFile baseFile)
        {
            using (var stream = await baseFile.OpenReadAsync().AsTask().ConfigureAwait(false))
            {
                return await InitializeTypeAsync(stream);
            }
        }
    }
}