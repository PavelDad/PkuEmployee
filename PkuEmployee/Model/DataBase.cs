using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkuEmployee.Model
{
    static class DataBase
    {
        static private PkuEmployeeContext _db;

        static public PkuEmployeeContext Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new PkuEmployeeContext();
                }
                return _db;
            }
        }

        public static void ResetContextState() => Db.ChangeTracker.Entries()
            .Where(e => e.Entity != null).ToList()
            .ForEach(e => e.State = EntityState.Detached);

        public static byte[] ImageToBase64(Image image)
        {
            if (image == null)
            {
                return null;
            }
            try
            {
                var new_image = (Image)image.Clone();
                using (MemoryStream m = new MemoryStream())
                {
                    new_image.Save(m, new_image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    return imageBytes;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Image Base64ToImage(byte[] imageBytes)
        {
            if (imageBytes == null)
            {
                return null;
            }
            try
            {
                byte[] newImageByte = (byte[])imageBytes.Clone();
                using (var ms = new MemoryStream(newImageByte, 0, newImageByte.Length))
                {
                    Image image = Image.FromStream(ms, true);
                    return image;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
