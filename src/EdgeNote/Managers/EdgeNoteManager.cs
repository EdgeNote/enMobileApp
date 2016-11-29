using System;
using System.IO;
using LiteDB;

namespace EdgeNote.UI.Managers
{
    public class EdgeNoteManager
    {
        public static EdgeNoteManager m_Manager;

        private LiteDatabase m_Database;
        private string m_DataFolder;
        private string m_DatabaseFile;

        private IPlatformManager m_PlatformManager;
        private ApiManager m_ApiManager;
        private SettingManager m_SettingManager;

        private EdgeNoteManager()
        {
            m_ApiManager = new ApiManager(this);
            m_SettingManager = new SettingManager(this);

            m_DataFolder = EdgeNoteApp.DataFolder;
            m_DatabaseFile = Path.Combine(m_DataFolder, "HWMobile.db");
            m_Database = new LiteDatabase(m_DatabaseFile);
        }

        public static EdgeNoteManager GetInstance()
        {
            if (m_Manager == null)
            {
                m_Manager = new EdgeNoteManager();
            }

            return m_Manager;
        }

        public IPlatformManager PlatformManager
        {
            get
            {
                return m_PlatformManager;
            }
            set
            {
                m_PlatformManager = value;
            }
        }

        public SettingManager SettingManager
        {
            get
            {
                return m_SettingManager;
            }
        }

        public ApiManager ApiManager
        {
            get
            {
                return m_ApiManager;
            }
        }

        public LiteDatabase Database
        {
            get
            {
                return m_Database;
            }
        }
    }
}
