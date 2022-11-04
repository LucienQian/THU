using UnityEngine;

namespace LUCIEN
{
    /// <summary>
    /// 飛機控制器 2D 模式
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        //[Header("圖片")]
        //[SerializeField]
        //private Sprite humanShoot;
       

        //[SerializeField, Header("圖片渲染元件")]
        //private SpriteRenderer spr;

        //private bool isShoot;

        private void Update()
        {
            // 上下 WS Vertical
            // 左右 AD Horizontal

            // 上 W +1
            // 下 S -1
            // 沒按 0
            float v = Input.GetAxis("Vertical");
            // 右 D +1
            // 左 A -1
            // 沒按 0
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

           
            //if (Input.GetKey(KeyCode.Space))
            //{
                //isShoot = true;
            
                //print("射擊");

                //spr.sprite = humanShoot;
            //}
        }
    }
}