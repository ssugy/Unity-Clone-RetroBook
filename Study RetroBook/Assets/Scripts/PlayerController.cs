using UnityEngine;

// PlayerController는 플레이어 캐릭터로서 Player 게임 오브젝트를 제어한다.
public class PlayerController : MonoBehaviour {
   public AudioClip deathClip; // 사망시 재생할 오디오 클립
   public float jumpForce = 700f; // 점프 힘

   private int jumpCount = 0; // 누적 점프 횟수
   private bool isGrounded = false; // 바닥에 닿았는지 나타냄
   private bool isDead = false; // 사망 상태

   private Rigidbody2D playerRigidbody; // 사용할 리지드바디 컴포넌트
   private Animator animator; // 사용할 애니메이터 컴포넌트
   private AudioSource playerAudio; // 사용할 오디오 소스 컴포넌트

   private void Start() {
        // 초기화
        playerRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
   }

   private void Update() {
        // 사용자 입력을 감지하고 점프하는 처리
        if (isDead)
        {
            return;
        }

        // 마우스 왼쪽 버튼을 눌렀으며 && 최대 점프횟수(2)에 도달하지 않았다면
        if (Input.GetMouseButtonDown(0) && jumpCount < 2)
        {
            //점프횟수 추가
            jumpCount++;

            // 점프 직전에 속도를 순간적으로 (0, 0)제로로 변경
            playerRigidbody.velocity = Vector3.zero;
            // 리지드바디 위쪽으로 힘 추가(점프 힘)
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            // 점프용 오디오 소스 재생
            playerAudio.Play();
        }
        else if (Input.GetMouseButtonUp(0) && playerRigidbody.velocity.y > 0)
        {
            // 마우스 왼쪽 버튼에서 손을 떼는 순간 && 위로 상승중일 때
            // 현재 속도를 절반으로 변경 - 마우스를 꾹 누르는 것과, 떼는 것에 대한 점프 차이를 두기 위함
            playerRigidbody.velocity *= 0.5f;
        }

        // 애니메이터의 그라운드디드 파라미터를 isGrounded값으로 변경 - 이것밖에 없나, 다른데서도 이렇게 쓰나?? 업데이트 문 안에서?
        // enum으로 플레이어 상태 만들어서 여기서 if로 체크해서 하면되나? 그게 나을 것 같은데
        animator.SetBool("Grounded", isGrounded);
   }

   private void Die() {
        // Die 트리거 겟
        animator.SetTrigger("Die");

        // 오디오 소스에 할당된 오디오 클립을 deathClip으로 변경
        playerAudio.clip = deathClip;
        playerAudio.Play();

        // 속도를 0, 0으로 변경
        playerRigidbody.velocity = Vector2.zero;
        // 사망상태를 true로 변경
        isDead = true;
   }

   private void OnTriggerEnter2D(Collider2D other) {
        // 트리거 콜라이더를 가진 장애물과의 충돌을 감지
        if (other.CompareTag("Dead") && !isDead)
        {
            Die();
        }
   }

   private void OnCollisionEnter2D(Collision2D collision) {
        // 바닥에 닿았음을 감지하는 처리
        // 어떤 콜라이더와 닿았으며, 충돌 표면이 위쪽을 보고 있으면
        //if (collision.gameObject.CompareTag("Ground")) // 기존 코드
        //print(collision.contacts[0].normal.y);    // 이게 일반적일때에는 1이나온다. 0.7f이상이라는 것은, 대각선의 물체의 노말벡터를 말하는 것.
        if (collision.contacts[0].normal.y > 0.7f)
        {
            // 누적 점프횟수를 0으로 리셋
            isGrounded = true;
            jumpCount = 0;
        }
   }

   private void OnCollisionExit2D(Collision2D collision) {
        // 바닥에서 벗어났음을 감지하는 처리
        /*if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }*/

        // 이제 바닥에서만 떨어지는게 아니라, 다양한 태그, 환경에서 떨어져도 모두 groundout으로 처리하려고 코드 변경
        isGrounded = false;
    }
}