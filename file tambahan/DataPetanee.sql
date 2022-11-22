PGDMP         .            
    z            Petanee    15.1    15.1                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16457    Petanee    DATABASE     �   CREATE DATABASE "Petanee" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "Petanee";
                postgres    false            �            1255    16458 !   deletelocation(character varying)    FUNCTION     �   CREATE FUNCTION public.deletelocation(_id character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	Delete from public.location where id=_id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 <   DROP FUNCTION public.deletelocation(_id character varying);
       public          postgres    false            �            1255    16459 G   insertlocation(character varying, character varying, character varying)    FUNCTION     R  CREATE FUNCTION public.insertlocation(_city character varying, _country character varying, _owner character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.location(
		kota,
		negara,
		pemilik
	)
	values
	(
		_city,
		_country,
		_owner
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 t   DROP FUNCTION public.insertlocation(_city character varying, _country character varying, _owner character varying);
       public          postgres    false            �            1255    16460 +   login(character varying, character varying)    FUNCTION       CREATE FUNCTION public.login(_username character varying, _sandi character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if exists (select * from pengguna where username=_username and sandi=_sandi)
	then
		return 1;
	else
		return 0;
	end if;
end
$$;
 S   DROP FUNCTION public.login(_username character varying, _sandi character varying);
       public          postgres    false            �            1255    16461 .   register(character varying, character varying)    FUNCTION     '  CREATE FUNCTION public.register(_username character varying, _sandi character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	insert into public.pengguna
	(
		username,
		sandi
	)
	values 
	(
		_username,
		_sandi
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
$$;
 V   DROP FUNCTION public.register(_username character varying, _sandi character varying);
       public          postgres    false            �            1259    16462    location    TABLE     �   CREATE TABLE public.location (
    id integer NOT NULL,
    kota character varying(100) NOT NULL,
    negara character varying(100) NOT NULL,
    pemilik character varying(100) NOT NULL
);
    DROP TABLE public.location;
       public         heap    postgres    false            �            1259    16465    location_id_seq    SEQUENCE     �   CREATE SEQUENCE public.location_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.location_id_seq;
       public          postgres    false    214                       0    0    location_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.location_id_seq OWNED BY public.location.id;
          public          postgres    false    215            �            1259    16466    pengguna    TABLE     �   CREATE TABLE public.pengguna (
    username character varying NOT NULL,
    sandi character varying NOT NULL,
    id integer NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    ananta    false            �            1259    16471    pengguna_id_seq    SEQUENCE     �   CREATE SEQUENCE public.pengguna_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.pengguna_id_seq;
       public          ananta    false    216                       0    0    pengguna_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.pengguna_id_seq OWNED BY public.pengguna.id;
          public          ananta    false    217            �            1259    16488    plants    TABLE     �  CREATE TABLE public.plants (
    id integer NOT NULL,
    nama character varying(100) NOT NULL,
    nama_latin character varying(200) NOT NULL,
    kategori character varying(10) NOT NULL,
    panen integer,
    siram character varying(100) NOT NULL,
    iklim character varying(100) NOT NULL,
    deskripsi character varying(600) NOT NULL,
    image character varying(100) NOT NULL
);
    DROP TABLE public.plants;
       public         heap    postgres    false            �            1259    16487    plants_id_seq    SEQUENCE     �   CREATE SEQUENCE public.plants_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.plants_id_seq;
       public          postgres    false    219                       0    0    plants_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.plants_id_seq OWNED BY public.plants.id;
          public          postgres    false    218            s           2604    16478    location id    DEFAULT     j   ALTER TABLE ONLY public.location ALTER COLUMN id SET DEFAULT nextval('public.location_id_seq'::regclass);
 :   ALTER TABLE public.location ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    215    214            t           2604    16479    pengguna id    DEFAULT     j   ALTER TABLE ONLY public.pengguna ALTER COLUMN id SET DEFAULT nextval('public.pengguna_id_seq'::regclass);
 :   ALTER TABLE public.pengguna ALTER COLUMN id DROP DEFAULT;
       public          ananta    false    217    216            u           2604    16491 	   plants id    DEFAULT     f   ALTER TABLE ONLY public.plants ALTER COLUMN id SET DEFAULT nextval('public.plants_id_seq'::regclass);
 8   ALTER TABLE public.plants ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    218    219    219            
          0    16462    location 
   TABLE DATA           =   COPY public.location (id, kota, negara, pemilik) FROM stdin;
    public          postgres    false    214   �"                 0    16466    pengguna 
   TABLE DATA           7   COPY public.pengguna (username, sandi, id) FROM stdin;
    public          ananta    false    216   �"                 0    16488    plants 
   TABLE DATA           g   COPY public.plants (id, nama, nama_latin, kategori, panen, siram, iklim, deskripsi, image) FROM stdin;
    public          postgres    false    219   #                  0    0    location_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.location_id_seq', 13, true);
          public          postgres    false    215                       0    0    pengguna_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.pengguna_id_seq', 6, true);
          public          ananta    false    217                       0    0    plants_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.plants_id_seq', 51, true);
          public          postgres    false    218            w           2606    16482    location location_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.location
    ADD CONSTRAINT location_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.location DROP CONSTRAINT location_pkey;
       public            postgres    false    214            y           2606    16484    pengguna pengguna_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public            ananta    false    216            {           2606    16495    plants plants_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.plants
    ADD CONSTRAINT plants_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.plants DROP CONSTRAINT plants_pkey;
       public            postgres    false    219            
   %   x�34�,N�M,J�K���K��K-�L�L����� ��{         )   x�K�4�4�J�K�+I�4426�4�*(�L���b���� ���            x��\�r�H�]��˪R-Y�݋	Y��r��V�=S�I�����������������9���@@�'�A�$�u��>�ɝ���/��I;�ۏ&y�o\�\<=O��5Mژ�M���ɇ�nl�J߻M/�2>=�kLa*�Q�=grio*s�W��[s4i��M^��ڥ[<vH��5[�1�Yz�w�m\Ň\�q��ڙ�a��I��v�W�ѦngҭݹJ�����|���0�gI�Ű��n:̺�?7�t����fg�.SZӞ%gg��_�vm�w��Ϛj�ݓ��-쒿�&�5���%�Hr����������'یx6�7�fo:[b�vS���5��xLU�n]eq�./��Rݺ�[���Wd%ߺ-ht��¤H��<���
4.m�>L�6Su�
��.A`�+_Xݭ_�^��đ[��=�����U�Y3#��E�z��5������d{�pl���y=��+���6n���݇CJ�]�C\��w�΁Sugr����+H�.o{�JF!Ӯ�S��MĽ���k�2fr�39w��@TF7y���le��62�g�5T����*�^��{�eҫ�4�s��ָj���A����u�x0��s�V:�����P��e�'D��������g��%��-Q��96�x�C�]��4��܂! ]<���ܴ5ĩ��Ε$�
�{��?��,���P�w8+TeEzvG���jS�"��rEF��:���N'|j����s:�`B���C}0}���`Jg3�(�2WB��-KO���`WW���c���)v�Җ�u��+� ��y�Ĥ��K&�M�1�ϗ�]��A䢦Al �w�Š��?��8'-T�n]�ծ0='j�x�S���0�%f�h�e��ϒȂ�k��4U�נ�ϧ�.��i���q��9���`]�}ē���C@�湪�
:st`t��]m8�R��i+���x�7�/�<�u
?Fv��>E�|Q���6��촔�k	aَ*]�px��"�<��T3�
-��ϡ��l�
�p`�CWe#��&��Sv��|��4n.��@��BY�/NdU���u�S��&K9�}�������~D4��O M���B���67�A�����3]���ł�-=��6�	R�ҳ���h��GB�<XHp�9����>7�w�O��"��n����e ,;Es��^�L,+��k��D��Y���+��R)�}-4�� �i� j�w ��Z���D��+�ғ�f�#$���?�Z����"=��	�'1�'�R�\o�+�Gwݰ!����9�5���uPy�4��G)؇�x����x��.�;*#�
{�;l��F����V�S�nuy������1˯�J݆�}��TW[�)ٳ~C�P�S(#g3����-ma���S.R�� �o�,��ð%9_��K(4���)\LG�GX
�~��"/��cq�Ⱥ೼��C�;����n&;��x��>:��<y��N�k��+����u��op��v�A��y��yRX����U�Ԕz٩rL���k�u#BV)�� 74�$	pFׅ�`�m��pz�57D��J�f,�`r]6��p��Z��J	�㙱�#G`�n�ZP��|�p�B�A0z��I;��X��]MJ�Q��:��6y�72����.�3u7(��n�h,���4.Fq�6�G2�w;�^Qq �
`�����4H���񰽕�
�Ϙ�T�<I�:��>�������|g�j����̣�E�!Pq0y{0��ȳ�I2������q(��U[C��d�f��!j"Z"Q�J�w���"��oǎ�k�����u}!ct��,i4�����R��)�����ǝ%zl�,��G}��JD����&��%���C�����	�f��
p��s��	HÒ�F���yO�R�{D/RC�ԍA%D��oKB�*B#��7���H�pJS.�X�������(J��J=����ၪ��QH?ê�{�9���G�J:C�fPE$/�g��=4��c�/�$�1�zD�b���h�!�s�/Xl5RM
fċ=城�/���ֻ�޵��R����Cə�NW��k����CDN��)�Ax/Y�{� s>��D�ЂN�*@x�#�$x�	����j�Ifɘ�bv���z$�4��!?�u
�,l��j�M�d�h�YodW�����_�R�>��rC�;�R�
����u��[�G?�G�k�3��r���L�CJ� k�9��e��y�����A�G�'		��hi���1���I@9���pe�ډ%�Td�K��^{C-VhD� E3�s�x*_���\}rǨ뾬a������aD���8� �ܶƔ���)���x,~�$�@��&W�
+��fc���J�D�R���\��"���[�E�|2?�#b���$���<\�P�	<�h��DX�V���Qj��2@�bS��j4T�y��̜dTe�t��F�F��{P��6��r��2(Ƨ#J��t���e7qj�"ZЧ2'e2-������B�^6�<x�M6��ؾu%sX��z������m,L�~�SCK�x��kI�}ݹ֩nk���S��*xy�ٕ�pv���lܚ/L�r��Zׁ08�r0�U^���.�9��TDi~�ʃ���}&�Pg7��ք��$����$��dh����r���4 ������+'�7���FN���*��	��p����$���j��(�-�Cv�;���O��V��Ōاt�q�r�1�4e� �7��Cpԭ��@ �y'���O��^���I�7K�%�P&]$oA�䦾��3�f��FUC��>�4䫢Q��u*��0{%1�q(�(6}��@1�V�ʩ��#�
l�,�I��
�a�M����!s�=�j����2ƙ�tKeK�ٶ�f��1�]����\�rf�^�/p����p�B�'�9`Arcs@d��]��o!�N�0&���Pǋ!�m�G�Hfj�ԙ�T���9Ku�wb.Iq��=t��",�"0���L���e�x-�2C��wk��[�&LE� Ps�Dd�JxV%�Õ�i�CM��w�(3���Wˑ��{���l��C�-I�u(J��U"�����8o��#Yކ���u��+�$��pʇFI�HPBo��JӬl4I7B�i���HV�����|;FS��B�(lZ��0���MKHx���ں�b6���k�#��|-49��V�R�>��1�c߮�-��!�;��0��ȥʰ�0t����*�$�yf͜s@۳��oͨv�� ����+S��B=���X�{^v��Ipyjl�K�2�r�*y�C��˒9��7��ߢX~��B��(m� �, �7-a՝��S2Ԕ�z�S��FL��)z�G�m,�=���.-n��ڛ7_��Os
�Q��ϒ_�>O�
�3.���2I�'�?:r�e��u�u��<=��y�%�VK�G��VI;K&|��qv�V;�u�+�T��z�bj� 8��Ï91��Z�(�>�lR�0~Y�9���<^_�����R/�yR!�	��7��i��*�Bw�>W.=O�q�6/���������o�B���b�߃��8��bQS��WI�҇�6�S��M:��_��k�x��n�$Ȗ��'ߒ�f�m}��fʷ}��!?��2�W��a�y�AI��}���c݂B����2%	/F�;������]�m��r�n��"s�'w˝.����8��D�k_�� Uk�tʗ�c}{���[3���	>�`�]�F�V8���v���^�Dt%�C���ċE\����[ꈓuׁ�ʋ��-t�M~�;�$�_�>2����݂�m�p~��l]˞��= &֥4�6Tq����U,#�^��Uӓj�ԟzZ��Җ��\���0M!��Y�~�S�����`9�Yia����ʷz�#}#��w>��O&mY�'̫}tD�w}+��1��}���H�F~�EO�R�h��j�&��O6|�L��[5��T�,��v6�Q>3x��4ur=7�RS0�sc����.�>>�c���'���U���L<��1! �
  �2�X!��&�%9�V��
�
�%T���Ʃc()�p5>kX&6Ƕ1U���Xh�t&W���?K�m�"�㚰�a�ѧ�W��Fi^B��dGh
�qH��<�P��WS,q�$>��ޭ���K1���5��:d,�tl�B���� )s�Cu=Ē�m���!SEO-�`�!�)a3XSH�RL��~�������	NYU?ċ1��-�^����L~b�Ն��l}�czM��J7e��Q�]��G�!����o�ch���?�M(����i�|`g�GJ�$�|�q���K��z���5�m9m�Z��9C��*sJ�S2�����i�� ��4;��7U��,�}Ŕ调�Ѿ�+�S\���m~j`U@�2�@hr}|��򶲮�ʡئAg0|�q ,욋g�Hh�0���+sP���܃�(�U3v�~Rb�T�^%��o��O����6V��{z�Yg��e���4�w�����ې��Z&u�:!�����ɇ��>nb���#>K>��He��>��ԃAl�h��:���/uS6|v|$�&��FF���h'���l���PT� ��M�fz��);����c�.�+qJ2�Լ���k��q�I��C"v�B�m�t4��B�]~\��ʆ��CP�4
ؗ5�?�-;�l�{,�
��i�6�u.M����9f�|��c��������7�b�-���ڿU�_��/m��X6ؔ��j��PI�b�U�C���e�IB,ٱIJ��x�r��A͞56͏z6���� ��Y�ћ�M*Z��w�����a5B���Cl�K���z<>	w-�W�x��um�O`�~�o�����/�@�K�Zp0$2��:,K��Y�|p�Y{�)%!�У9��LYI�'��z���t}��>��t�A/����
Z��<�a~��j}���I_7m^��ޕ�#����t9�m��^���M_־Җyo"�@VVhF�n�@}������y�|L����mbX��Y�Ԛ]ɣ�C�i-Ҩ����:���#��K���H+k� ��������:*G�G�D.���ud��%a��?����Ҏ�FM.go!�f�l�����)d�\�l5R,�*+�W��z0����,;��z#�<y���
0�?j<�Ŀ��up�|��'Qn��C��R��~\�
ɻ86tꌆ��~�%�ftK��W����4y�e�E��1(�6�ZE�:������uk�蝵i�4�k�7��b#�n�`{���g����&����ÐWpR9`q}�y�"�|\�rrȧ&�6r��{ Sv[���i!r�a�b�	�gc�صך2�嵓H�q�����D`�=.d�>I~aPZنH��/]���E�m��Z  �����7�N���&���ajoE��������ݤ2H�c��e]=H3��5�^���h�2#�kU
j0�oW(�lc�J����$s������Y?���N=�ħJ��ƕ �R�������Q�,c��Cg��]�S�����\ ����0oz#��S�7=��{u��U8y��j����i-tn�Ge�gDe�o��9T��&����qr�yT��4��}�ä�M-�WI��@sm$	�H�>�'�/�llb'����~W-�4TlQZ�ŷ!��z��w@�{���U|�R�4��&w�2���{r� �k�@|Ll��@�4����ʊ&}���΄�2/e���+�/�ޔ;ʭ���c��fnΘ$�-��U�wy�G�賺��8�j??���`��j5��Y�#��U�aUG-�X:ۺPi'�'���<K�z�Z��/`�i�y.��Ƚ�R#�qS��m3��b�y�c>��}���[Im=4τ*��d�w	��I�,��(�k���:t���S���W00Q[�7��O&ϣ`���p�ܚ�̓k��ܖ?r�`�H�s����0���+G��e^�u;	Oa�E�7M/9����L]�4�QFq�A�\��y�Ὠ�O1j�e'�}s��4�J�H�W��{W���8��w�yOz0TpB��f�]!!Ui4'�i����a���Yr��6�m+�O�{��?R�fҁ�HR�5W�U�NZ�FS���e��e��diOv���LB�3�p�Y����TN�Z��RK���1��P���O`�(��'�%\k��K���WU�L�w��J�G%e9��_�]���=Ao�p=�#n����R�8'}@x]��z�qֻF����h����6F�Xu������m���1�X�TO�x�(��&��l������~�Y��/�\䮐6H5c�a&��&�z�.�c[9�`����
�XWw)Ks-�������$�l!�vz�K��5�H%�K�BK]��?�}kv9DA�2i�45��Ǵ_��,��8�.�_E�xQ�()B�7�]h.�	T%��5�`#ګ��G��F.��}��5ws�C�{rd��yR���.*u��*�4[J��]��`��4 ܑ�m�#�=�q2��e��mp0tϮ/���o�/�S�����s�0�o��H���Z��_��Q�����{�9��v7L�pIE����d�Hn��k��w]�#�1[r���@^�D�����>��1]$ڶ
��	���l�g��^[ڗv-���]g<���P�X�w�F��������?�z�     