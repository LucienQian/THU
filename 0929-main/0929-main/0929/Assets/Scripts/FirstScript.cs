using UnityEngine;

namespace LUCIEN
{ 
    /// <summary>
/// �Ĥ@�ӵ{��
/// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѱϰ�
        //�Y�� �ֱ��� Tab
        //�榡�Ƥ�� Ctrl + K D
        //������

        /*
         * �h�����
         * �h�����
         */
        #endregion

# region �ƥ�ϰ�
        //����ƥ�G�C���}�l�ɰ���@��
        private void Awake()
        {
            //��X(�T��)�F
            print("Hello, World!");
        }

        //�}�l�ƥ�G�b Awake �����@��
        private void Start()
        {
            print("<color=#348EC7>�o�O�}�l�ƥ�</color>");
        }

        //��s�ƥ�G�b Start �����A���榸�Ƭ� 60 FPS
        private void Update()
        {
            print("<color=red>��s�ƥ�I</color>");
        }
        #endregion
    }
}