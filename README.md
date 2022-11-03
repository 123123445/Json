# Json
텍스트를 사용하기에 사람이 이해하기 쉽다<br>
Unity에서는 필요한 데이터를 주고 받거나 진행 상황이나 설정을 저장하는 식으로도 쓰인다.<br>
Json데이터에서 오브젝트로 편하게 변환할 수 있는 장점이있다.<br>
배열로된 데이터도 저장이가능하며 객체 안에 객체를 넣는 것도 가능하다.<br>
정수,실수,문자열,불,null 등의 데이터 타입을 지원하며 주석을 지원하지 않는다 고로 Key값이 의미하는 바를 정확하게 표현해야한다<br>
작은 문법오류에도 민감하게 반응한다.<br>

<h2>유니티에서 JSON사용하기</h2>
<h3>Newtonsoft 라이브러리 사용</h3>
구글에 Newtonsoft json 검색하여 Json.NET - Newtonsoft페이지 찾기<br>
Newtonsoft 깃허브로 이동후 다운로드후 압축을 풀고 Bin폴더에 들어가 필요한 .NET 버전을 선택 (보통의 경우 4.5버전을 선택)<br>
DLL파일을 프로젝트안으로 옮겨준다 Unity 프로젝트 세팅으로 간후 Player에 Other Settings -> Api Compatibility Level을 .NET 4.X로 변경<br>
<h2>주의해야할점</h2>
Newtonsoft Json 라이브러리로 MonoBehaviour를 상속받는 클래스의 오브젝트를 JSON 데이터로 시리얼라이즈할 수 없다<br>

<h3>JsonUtility</h3>
JsonUtility.ToJson()를 사용하여 오브젝트에서 Json데이터로 만든다<br>
반대로 Json데이터에서 오브젝트로 만들때는 JsonUtility.FromJson를 사용한다<br>
나머지는 전부 동일하다.<br>
단점은 기본적인 데이터 타입과 배열,리스트에 대한 시리얼라이즈만 지원한다<br> 
직접 생성한 클래스는 [System.Serializable]를 붙여줘야만 JSON 데이터로 변환되고 딕셔너리는 지원하지 않는다.<br>
<h4>JsonUtility 몇가지 특성</h4>
- 벡터를 담을떄 불필요한 값을 제외하고 필요한 좌표만 저장됨
- MonoBehaviour를 상속받는 클래스의 오브젝트를 시리얼라이즈 가능합니다.



<h2>JSON 데이터로 변환된 정보를 파일로 저장하는법</h2>
system.io system.text newtonsoft.json 네임스페이스 using 선언<br>
저장할 경로와 이름으로 FileStream을 만들어준다.<br>
JSON데이터를 Encoding.UTF8.GetBytes로 byte배열로 만들어준다.<brFi
저장한걸 FileStream.write로 써준다.

<h2>저장한 JSON파일 읽기</h2>
FileStream을 같게 설정하되 FileMode를 Open으로 설정한다<br>
생성된 FileStream에서 stream.read로 읽어들인 다음 데이터를 반대로 string으로 인코딩해준다<br>
그후 문자열로 디시리얼라이즈해준다.
