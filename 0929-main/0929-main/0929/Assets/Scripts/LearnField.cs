using UnityEngine;

namespace LUCIEN
{ 
    /// <summary>
    /// �ǲ���� Field
    /// </summary>
    public class LearnField : MonoBehaviour
    {
        // ��� Field�G�x�s���
        // �y�k�G
        // �׹��� ������� ���W�١F
        // �p�H�Gprivate�A�Ȧb�����O������s��
        private int lv;

        //���� ���w�Ÿ��G�N�����k�䪺���G���w������
        //���}�Gpublic�A�Ҧ����O������s���A���

        // ��� int
        public int enemy = 5;

        // �B�I�� float
        public float speed = 3.5f;
        public float jump = 7.5f;

        // �r�� string
        public string namePlayer = "�p�M�h";

        // ���L�� bool
        public bool isPass = false;
        public bool hasWeapon = true;

        // ���D
        [Header("��q")]
        public int hp = 999;

        // ����
        [Tooltip("���a�C���g�L���ɶ��C")]
        public float time = 10.5f;

        // �ƭȱM�νd��(�̤p�ȡA�̤j��)
        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float walkSpeed = 3.5f;
        // ���䴩 int �P float �H�~���������
        [Range(1, 100)]
        public bool isOpen;

        // �ǦC�����G��ܨp�H���
        [SerializeField]
        private int countBoomb = 7;
    }
}
