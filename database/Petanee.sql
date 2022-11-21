PGDMP         :            
    z            Petanee    15.1    15.1                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            	           1262    16424    Petanee    DATABASE     �   CREATE DATABASE "Petanee" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "Petanee";
                postgres    false            �            1255    16425 +   login(character varying, character varying)    FUNCTION       CREATE FUNCTION public.login(_username character varying, _sandi character varying) RETURNS integer
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
       public          postgres    false            �            1255    16426 .   register(character varying, character varying)    FUNCTION     '  CREATE FUNCTION public.register(_username character varying, _sandi character varying) RETURNS integer
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
       public          postgres    false            �            1259    16427    pengguna    TABLE     �   CREATE TABLE public.pengguna (
    username character varying NOT NULL,
    sandi character varying NOT NULL,
    id integer NOT NULL
);
    DROP TABLE public.pengguna;
       public         heap    ananta    false            �            1259    16432    pengguna_id_seq    SEQUENCE     �   CREATE SEQUENCE public.pengguna_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.pengguna_id_seq;
       public          ananta    false    214            
           0    0    pengguna_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.pengguna_id_seq OWNED BY public.pengguna.id;
          public          ananta    false    215            �            1259    16447    plants    TABLE     �  CREATE TABLE public.plants (
    id integer NOT NULL,
    nama character varying(100) NOT NULL,
    nama_latin character varying(200) NOT NULL,
    kategori character varying(10) NOT NULL,
    panen integer,
    siram character varying(100) NOT NULL,
    iklim character varying(50) NOT NULL,
    deskripsi character varying(600) NOT NULL,
    image character varying(50) NOT NULL
);
    DROP TABLE public.plants;
       public         heap    postgres    false            �            1259    16446    plants_id_seq    SEQUENCE     �   CREATE SEQUENCE public.plants_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 $   DROP SEQUENCE public.plants_id_seq;
       public          postgres    false    217                       0    0    plants_id_seq    SEQUENCE OWNED BY     ?   ALTER SEQUENCE public.plants_id_seq OWNED BY public.plants.id;
          public          postgres    false    216            l           2604    16433    pengguna id    DEFAULT     j   ALTER TABLE ONLY public.pengguna ALTER COLUMN id SET DEFAULT nextval('public.pengguna_id_seq'::regclass);
 :   ALTER TABLE public.pengguna ALTER COLUMN id DROP DEFAULT;
       public          ananta    false    215    214            m           2604    16450 	   plants id    DEFAULT     f   ALTER TABLE ONLY public.plants ALTER COLUMN id SET DEFAULT nextval('public.plants_id_seq'::regclass);
 8   ALTER TABLE public.plants ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217                       0    16427    pengguna 
   TABLE DATA           7   COPY public.pengguna (username, sandi, id) FROM stdin;
    public          ananta    false    214   �                 0    16447    plants 
   TABLE DATA           g   COPY public.plants (id, nama, nama_latin, kategori, panen, siram, iklim, deskripsi, image) FROM stdin;
    public          postgres    false    217   *                  0    0    pengguna_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.pengguna_id_seq', 6, true);
          public          ananta    false    215                       0    0    plants_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.plants_id_seq', 51, true);
          public          postgres    false    216            o           2606    16435    pengguna pengguna_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public            ananta    false    214            q           2606    16454    plants plants_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.plants
    ADD CONSTRAINT plants_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.plants DROP CONSTRAINT plants_pkey;
       public            postgres    false    217                )   x�K�4�4�J�K�+I�4426�4�*(�L���b���� ���            x��\˒��u]c�˙��V���CZ8��x�CR�i+B�M
]���$��J���7���O�%>���D����7�* �y��@?�n��f_L>��~2��r���ѓ��C9Y����|o�}������L�c.��M9��T����s%�O�5��q[�5�O�З�d�]��eMޗ�ٚ�i/���X�޵��M�k�;S8<}k�����Ɋ+~h�{�3���\+[p����r�G�a�-Β7f�m�݌Xu�?n���!L9������ښ�"��ݛ����w<�E��~x��f��]������a�|R��-Vjp��"���f��u"���7coF[c�a���v0�n5�ͷ��8�X�ƶ9nݺme��K��o�¹��le��^.�����[�!�_�/l���j��]B�\W�`u��w�>���|�s�o�mז�5�4U"ϫ�)x��x�>�L���������]��˥��ac7�����(�}8M1>�u��U.W�Tԍ�T�nm0��b�a���-T��Z�a��ܺ����T�Y��Y��BN���A,0 ��M�b����|r���8���.�u\��d��|ϟL~}�Px)��׮��/`;���F�ژ��qUb�*���Z��$���t���uww��-������ՠ�x�7�V�������L5��!/���Cm�s5%�7�=��?��iϹ���pH8Ǌ�a����"�(:�j��WсL�<gΌ~�D@<��:��5f���jm�c�j�?��u����;�s�k�S�+�x��ZTmU�/*�uTe��>t5$R��\͗�@�5ז5ޗ�n��z�-�b���0�ĥ���٭��K���ąz\-�k�QX�
+A����H�i�
ڷ�ګM��kp�gK���8��$�q����_��Kcĕ�������ڈ�98�n��6\qE;��M�������5/ d]��#�*d�bk}��q����a4m�x ��ѻc��.$0�xF��v�AD����f/q5N� ��"�ɧ_�IX�Dki�h���hܩ���[�0îA08�N�w܆wo/��Ò���H�7f��gl�� �������!fn(\�s�9��Y>���-o�`{��9�E�:f����/D6�m.؄|����%΍�6�g���ڸ� l�Ө��@OZ·t�B�?��-[P�Z��,��]��]���)G�W�+��H!��%�'�w>ʑK���� ��	�>ʛU�i�+~6]�Mv�C�23���)[	�1x�8���<��><^�>9+GE&�y=��&
�v֍	��:o�Fu$Q�X���]�X8�DK�)��m�����"�f�/���9����z[���}<+�6�Y����ߚyKr�A�!N�H=�(����3���q��������`N\?�,�%��E�<T1� ���0�}7�����8P����O¦�]�r�q�����+��Q I$�B� GEM����BA?�~���HE�b���5�E����a�[�)F��`�?���Q�KUxRvS������$��Z%��4��;
�S� 4�5�D�j���~xr12�&\/�i 5#�+z��n��A����/벗��9�K���t�l�dܺɃ���:\X���N�Ƨ"�ow�,/)��<��� ���.�r�t�;YY�rӬ���j�q������>n:��;۶-xr��Ƚ�(�ف�l(�����������MN�mH+�8m.�_��9a��x�����@��>*��2h�=>;�L9c�\�7n�X��=�H��4ݐ�����WY��>�v�dp Q$]����k1Z���-�kF���E��>+�R-� $4UХ�ĸ�#�-��? T��哔s"oDs�3��5�_�Z��o��%�$I�#��G5 �� ��	I�C����5��Ϧ�f���5�헀W��~t��+����X)���Crk~a��Y���Ԫ=�`$>�"3s�ox�ja�b�4�H�&Z<�L�3)[���ve�̝������è���7do��QC�hΒ�	�����X}J���&+��4��SLs~b%�*�R�R�X����zb�&s
��"Dgt+l��jiL=c�a�Y�+�^�V���ET�O�2���,�d���Bd�z�=y�_ų�O�����TR���7���tB��x�rB��Cz�#�ɥ+�!8vR!�dn�qέ\9��ʡ�h�]�U��ܰp��J%j�(E�c1�JS�ZL��e�
yv5T��-󥻺����vLX�	�F�oO<]"C0F�W��y��R���#���FYj�Դ)ը�J�f7��{�u�ڰ�Ĩ����-� �g���x�ލ���Cԛ��]��+e���U+�4��0�J*v<������k�E$�|�Ra�Z�lӲ^�FQ�;����[��r^��Dū#钇�Z:��ĥ�ceŀ�Z��舘X�X�ǒ}Z-�]��_0��]g��4��&�7�����$���+a���_�LI����Y +��;78uc-^�3���K���m�2��X��[��M	�PЀU5��q�3T�e+HE�U����?� �4xʽ����&��������"%��M�
0�Ɠ$~i�m\f�y��;ʡ���}
�3Q����Eq��-t�������u,;I2�;Ay�e��� �cA%E�>�@'�$ћ
��E6_��z�RG3��k�͸�xI����\~T���z#��#)�,\IĠ�y���d�W��]�E9�`�/���X���\T�x�$�{Q��`�V����Q�J��eCå��i}��*l�"�E�+ҺX@��e=�`'@��m�X�^5��Qi����R�16Ә��|����hK&�ڪ�p��I�c�O�c���>{eH^ ]����'�#u]��������D9g���4`�B5r��r����Ă��i)Q�2��D��� �G1;��ճ-)�C�*���9�5�PM�K��yH3	�C�8;�̩���]ӑ9��c~����-�:.a��� �����:tbU:G5��<��x�;6��k�zzk!�(���|��6� )�HrA�g
.�4�q�(­	�{����[k�c�~{�`�MBݭ��	XcO�Z6q�����q�	��g���T��-��Dv_EV��)dױP�󂮮�[����:c}XVk�R�_yV���Q��R�<ʓN ����E��O>�;�qV���v��9Ѡ�^�q�R<�{%�̤)pC��\^�9YPUw�����O7u�zKo;	���J~ę1��������ao��[r�0�(-����"�FP���#���!���`aHB�Kn��H�{L�[":=�J�i��ٗ�_�e�����P�z�� �;>>�V���Y�f�w7 Ub]��p&�d�������s`�g��΄iǘ�~6���W����v��p����Y��{�M�f�?vuI��f�m�c��}���\r����y��.�N��KUϳ�[�*��P쁑�2�|-��9&�����%��{@�d�Ť�))[�z�OB#ڗ�i�{�X˟}!|Lc�Qz,�Ȉ���G�m�v� ��������0��~JZY~��Bx@R'г�T�g/�<�!ܯemY0D���D����kCQlt[n�m�������>��O<��K�3�W#���^�챙���쭙�>VXB\i���e�����o���{�jNb��8!&�*�mm|��#�*����U	/��p�!�s7�s�-����lI7�����M��?���	=z�Q�m��1-[:���1���k�G�٣?0w�l��3}�[La���� ��i�����b�Yikf�!8�6�F�{#c���|aݟL��J�Q4IA8�֣�0߫ _����"E#���}�Q�2)�� Dx�_,���)ɣE�B�/@fZ�9�}(��~�f?�"�Īz`d��b�)�#=�z�r"H�^����(�+���2���"�	*���qH�MDR� s
  C*'�t����o6.�@)O+��Z$T���b!�jAa�Q����Xc��o�"'���Y�Ы45�F�]�iޢ�FR	
�d7CY,�����x�ȨϠ�[�72)�������su!�Æ�a�F�܆,YJ�{�!�C��3vhL�TD��a�9��/tRI�w�X�)ד�25M����5O�~�1�I�B1�̯�_8����^YN�>�aPH�����4s���7�1�J0��]��<;ܡ�;߿l<Rg���gQ�\�hN��]m?Y�m/�����U|:W�M�#ǒ�������eX�u&�`ڱ�d�7�j�m���ً -��l!�̥#r
�j���-v�gM���a��kC�K�ŀ�a�!<�gKFt��X��ե�$�;�|w�4Mr-҅]2.@�Ur*�����>�JǕ?���爒qC9Ǟ��_|VV��J'!?R�u��;
�����*�#�'�(eN~I������C��4��ъ*�3.�8����φrf,��̤7��k#�=�M�"�����hN�ԝ�=��zqb�O(��ٽq-�P&ۗ9g��3��qc`Kqd�{x���'����(G\�3ΐ���[����H'ml�_����\⽅p��u�[.���o�J��s��Le����n��{�櫲c���M��>�pkl�p�=��/�������xn�?�aY3|Č2v(}RI�����n���n��@�q�n���vQ������ɓAG��\0��I��#������;����E�J��?k�)����9.�H���kQ������	�@'�9x}����x��+��*���B}q/�2 q��~R���c1F�FM*>6��9qO���e)���6�D��48�2�s<n���{R��	�'=�a������9u��6n9b{ƈ&Wk�'J3�l�6ɺ�ع�75�굸���A[����:�R�Ma�#��"H�b�����˸�Xe�L�Ą���ܬS��QB�h-f���T�kGf��I���E����g��U�I`�G ϫ"N�ӈ�B}��?����7�-�|�ޚ�Cj��$3$oa�V�#Pu�������.`U�-�S-J+@��Jm�r�����v�0i��?V�
��^������+��ec�9�:䯋�4fʡ��oR�!m'�
[�7L�$��g�jk8(sK"���o'���vk����W���J����f���npk~���%� ��ƣP�>�<E���`ޝ�?>�:3#�����Ap���E *�r�&�w�S�Iv����R>�xp2*����9��G��=���jN�T�;a�5ُ��T��&����it�4��'���8^���'��pɘ���?�v����\/_�N�.2�%���yi�����x�v�}Z��-�BՌ��K뮽�au?�#�<���=&��tV�u�,<3�ƺ���k_�����)d�eb^�:�F�_Ȕ)W�ZK�m!�����)``�̙^��Go`��y�R�߬ά�	���d�
3A/~F/[��ǹ��.��`�l�|�X���<���l=J8!���t���ޤ�<ja��p�O��0�RK�	��HVpG�+t��_�"�Ƕ���AUA�~:��-{��Pur��g��9��Gn�N}�ui��������G��`�k~��ޛ8�&m�ilkC���),������-B(*��8�nZ��T-��'�G`�_�I�x���\g<����+߄��/�!E�']�]
�/b��"�j��!C�6�G��v�_n,��\hr�u��H``"O�;,��W@l4ϥ}
y��T<v:~��ǵطfb(�v��nsw+�g���@mL!���H,��_�u¾���Q��`f��{�K��ْq���u?�|�7�f��Z�u���u�� s�=��%Z����?�_��8��7�.��i&Z~#i��%�|1.\h]&(��9Mi$�U��2>R�!���kR^�P
��k�ڒKl(<�:r��-�3O�Hj���h�A-&�0mJ6ޞQ�F��5�����,�pq�*�iv3L� �����<��
�y��x�v��{�*r�����U�eǧf;W����,�����
4�"����oZ'~�o��/�����b	)�?��?A{IY W&�S�g�9���ohޚ�?����o6�z>�!���-��N���`֜1����ٙ������nj3�Zn�&��{�{s�xoj�"��&�l�0�l�Q^�?i]�1������~Pt1u��~�;�Of�i��e1�J&	�;��
y�g1�o��^�&h��UI���-�t�WS�3���}ֹvu��E:�繍�:.{��*���@���݀K�|���]�w�5��~�s�2���Ӆ0P��Q�dNoZ{fhg��#�bJ��;W�ɮ�3Ŝc��?%�n����������NT�^�ܤW�g߻��r�L��"R���Sh��؁3b���c.��|ݢ�������k���0;�w�iF�C07����x|��fAD���i��Fe1N�?��C�e[�y��c@��Y����W];M��1������_,��Hbӕ�"m�����x��c�¿�@0^�::����طS-��q��h�Z���Ғ�ˁ�v��?��&�     