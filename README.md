Tətbiqi işlətmək üçün:

1. SQL Serverinizdə tehcizat adlı verilənlər bazası yaradın. Bazanın proqramdan kənarda olması məqsədə uyğundur,
   çünki bu klient proqramı çoxlu istifadəçilərin eyni remote bazadan istifadəsi üçün nəzərdə tutulub.
   (Biz bilərəkdən təchizat sözünü səhv yazmışıq, for security purposes necə deyəllər :P )

2. Bu README faylı ilə eyni səviyyədə olan tehcizat.sql faylının içindəkilərini kopyalayıb,
   yeni yaratdığınız verilənlər bazasında execute edin.

3. Connection string aşağıdakı kimidir. Bu connection stringi istəyinizə görə App.config faylından dəyişə bilərsiniz.
   connectionString="Data Source=SHEBEKA\SQLEXPRESS;Initial Catalog=tehcizat;Integrated Security=True"

4. .exe faylını açın və portala aşağıda göstərilən istifadəçi adları və şifrələr ilə daxil olun:

   gudrat:0505545453   - Bu istifadəçi ilə girdikdə, sizin üçün sorğuları qəbul edən şəxsin pəncərəsi açılacaq
   fariz:0517788594    - Bu istifadəçi ilə girdikdə, sizin üçün sorğulara bazarda təklif axtaran təchizat agentinin pəncərəsi açılacaq
   alvin:0517504043, huseyn:0505698877    - Bu istifadəçilərdən biri ilə girdikdə, sizin üçün audit işçisinin pəncərəsi açılacaq
   yusif:yusifov       - Bu istifadəçi ilə girdikdə, sizin üçün təchizat portalının bütün tranzaksiyaları göstərən pəncərə açılacaq

   Ümid varıq ki, hazırladığımız tətbiqi bəyənəcəksiniz!
   Hörmətlə, qu_ce_son_kurs_uşaqları komandası