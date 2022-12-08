using UnityEngine;

namespace KID
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destroyTime = 0.5f;
        [SerializeField, Header("�I��|�R�����W��")]
        private string nameToDestroy;

        private void Awake()
        {
            // gameObject ���}�����C���ت���
            // �R��(����A�R���ɶ�)
            Destroy(gameObject, destroyTime);
        }

        // �i���ƥ�G���V���� (Randerer) �X�{�b Scene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }

        // ���i���ƥ�G���V���� (Randerer) �����b Scene �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // �p�G �I�쪫�󪺦W�� �]�t (�I��|�R�����W��) �N �R������
            if (collision.gameObject.name.Contains(nameToDestroy))
            {
                Destroy(gameObject);
            }
        }
    }
}
