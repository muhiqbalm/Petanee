PGDMP         +            
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
          public          ananta    false    215            �            1259    16437    plants    TABLE        CREATE TABLE public.plants (
    id integer NOT NULL,
    nama character varying(100),
    nama_latin character varying(200),
    kategori character varying(10),
    panen integer,
    siram character varying(100),
    iklim character varying(50),
    deskripsi character varying(600)
);
    DROP TABLE public.plants;
       public         heap    postgres    false            �            1259    16436    plants_id_seq    SEQUENCE     �   CREATE SEQUENCE public.plants_id_seq
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
       public          ananta    false    215    214            m           2604    16440 	   plants id    DEFAULT     f   ALTER TABLE ONLY public.plants ALTER COLUMN id SET DEFAULT nextval('public.plants_id_seq'::regclass);
 8   ALTER TABLE public.plants ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217                       0    16427    pengguna 
   TABLE DATA           7   COPY public.pengguna (username, sandi, id) FROM stdin;
    public          ananta    false    214   �                 0    16437    plants 
   TABLE DATA           `   COPY public.plants (id, nama, nama_latin, kategori, panen, siram, iklim, deskripsi) FROM stdin;
    public          postgres    false    217   �                  0    0    pengguna_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.pengguna_id_seq', 6, true);
          public          ananta    false    215                       0    0    plants_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.plants_id_seq', 88, true);
          public          postgres    false    216            o           2606    16435    pengguna pengguna_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.pengguna
    ADD CONSTRAINT pengguna_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.pengguna DROP CONSTRAINT pengguna_pkey;
       public            ananta    false    214            q           2606    16444    plants plants_pkey 
   CONSTRAINT     P   ALTER TABLE ONLY public.plants
    ADD CONSTRAINT plants_pkey PRIMARY KEY (id);
 <   ALTER TABLE ONLY public.plants DROP CONSTRAINT plants_pkey;
       public            postgres    false    217                )   x�K�4�4�J�K�+I�4426�4�*(�L���b���� ���            x��\K��H�]����ʌLK)��^����*��Ӳ�fڬ�6AIF�� BjjUw��lfN37���{��dJ��$����?ȋ�����/���I{3�O&y��]�<�<O>�5mښ�Mw���Ǯim�L?�� �2>��ε�05�(͎3�t0�����m���M:�]�׃����Ui�wfc֦>K�󾰭�y�0s�[�9�}c�Ǽ��ьK�h�G�5��n]-Kp�����u�ƭ�0�{I+�a��`5=f]�kkzN�CC�W�5VoSZӝ-.^$��j��=7���^`/ /n�0���
��:/1?$5/�#!��9߰��m�i�u��������l�q�Ś��4�N1t�*쫖���/yd�|�6����&�H����{/!��v��l}a1M�� �������<���8�zc��Z�ԛ��{kЩ�&�n>b�]rיl����fk �wA����Ǚ��˧j��wa�A��a��iW��]�u8��7��rc�
�A�w�(�#Ϲ�iW����|�f���C�{����3�W���U��y���a�ڦ�����g�34����T�^��;�eҫ�4��沜�q��/�E��z��ce��g��g�GH�e��yx��������J�[Ri�X96jj�M�}��-������ž�4��v����֕�
'������:��YS��~Iy�P*����_?`\�� ��(L�*ܧ�s��������cS�!y����d���+q���ޖ�����w��T��\gNq'�vԓ*j���μ�K'@�)!�,7�r������Y��q�C�EC�j�n����8'.-L�n\���0'jqy�7���	���.�W8Z��V�e���0o�v)�?2L�!�c����]{����4���+��k�V5e����{�w�6T��W�9�J M`#R�9�ň9� R��Ue�NQ�6�@sz�� �k�"�6-'���F�/.�q�S0���v��&/�����l�l�_6h�@M�\o+|��2�X��Bs�XS�4O���-���@��uA��qk��>	�2��O�@��B�w*��`���5�7/�b�U����l�>��7�;K_O��R������7s�3�.?��q�ޫ�oMtN^�a��Uj�ԭ��p����#�f������5r�;���vUϼ�r�GW�U�=ĩ�g!���Lt���9���/��C{Ɔ�y���2�\�?��v��[�މ��i j�;�LQ�[���L�	`paG�[\^C�5��D�e4�N^\z��H���I���~V7�9x�ɑ��,S���M>����BV��ВKsHdg�F�gY��V���I�ԑ6�E���^�K��u�x�@7&d�c��t��~�ݛ�3���0�(h	�������&�@7 ,M�qлf�N0���7'#�y��q`R�o��*�;�l����9 ���<��R8��X���Q�W5���O��5̞ǡ��C�����>@֑�N��G�)�y����M�aP�9���;��24� ��+��'�S�FN���X�iS{V|������I��{��ѿMxV��-"���Nm �A^���˼���4�K�i�Q�Iju�{c�|e�6WA�����Ị��L/��2q�X }�8�`�U� ;X��p���E��.���@�	�;[�3�*pp�X�h���!�i�]e�F����av+}��5k�9�19[�q���������!HF�o@��K���Ù��}�`-z�ez����1��Q]4�:[@�^Q��.�����Z2��\�)����W��+�����x�N��ez� 3H0�#�Q��|��Y���~��I�3�{�Q���{�c�~J̠2�|�|�Q�w���)���s�tb�E�� `�-�U4�Ϧ���� ���`��O�>t��3q Q��(w�>_�l��_��xc��D@������#�q鯸�r�m�c԰H�*2}��3IRT�m�y��̃�&zI<���\�#pЇ`w(��<u��)ҝ{4�	���zV�Ϲj�
��g� ��9؁a9.U�� %�_�$��z�jpl؝���p��MX@�+��j���~�򖺼�A ��	��*yO��L��a��/.n�'X�x���?>R�ѝI�R�&�!�D4�)\Nx��W� ���f!�aNR#��ĩ9�)�dV�յ����fF;^��Ho�����)jThd�n_�^��%�LW��&�a<����������~��R���qi?��/�"�.22��1�M��p"�\u��ld���}���(S-tfLb\]%�-�����Q����	���A�D[\��`�JO)��H-����3Z�$��p�*~W�Ր�X�;����hw��61������HI�#c����d
H�WG�#7�����ĩ�g�ZA7Ɯ���y01w�U�;�;�����0ye�ΕL�0\Ъ��#���	_�E�~�C�#����8�XL2�qm]��5���߫9�9	��Ք@g8�?�Ҭ݊/����f�H�*G`��Z���� M��+p�G�C���>L�K)�$<�ם	�Y�d{;�堕equ��s���p׶��O2��0T�����e�ܒ�n�!�;�IH��~���	�kD�![�:7�ۅd��[Sb:!�R�r��|�
������ȡ�w����_�%^�A@b�y/���~Z���$�1���-Đ�j�x�i⸉�Z���B�,J4ye��8BA����d��}pEH��+�#���N��T`g��r_1�Ō��yH[1�8 m�'?���T���j[Jb���b-�q���W�� �:gD��|�ͬAW/@"Z���!��,��e��#c����0~R�C�Ϙ��vr'i�b�}���?�f8KuJ&b�C��D�:�'���& �݁?����G���Jf��n�J(�ѪBn�\\���HN�M�T��?C���W�,7=Q3��u�u]�$V!�����8Hc��q�(�G�sb1ʾ���˘0����>F�iK�@�;!�y�ґ�r�,��%��!V��L��$�붓S�lw��~��R[�e�}�&�]��1������?q�.�����S��M!;��3f��3ĕ�|ӄ#8�i5�*)��qKM��Ld-9�������؜��}���"��酟���M��nz��p3N쏫g�I�[�Xw�'�Sz�����H�ʒy�}�j��>�<��E�I��w!�'�Л���Y��0&$&����B�Z`�y'���๋ŜG@P(�k�íW�|�C?AJɯf�'��=��j��������8�i���'��8�U����i$����.Ue�ҿ��>��y";�-ݩ�YV]ImUI)f�����d�w.�����=ro�7k~ٔ9�n��	�����R�@��%=��4H]-oq}��a�]^$� ��'��%%�Ӿ��R2:�ʿ��8kpa�JpaJ[$c��v�o�0��،��|����=D���{|�] !��ۮ �:M��5(Ud֩�������,�[����)1xO��@���$vu��n�չ5�w�X�O7�+�#�'N1o9"p�����{0_���yjag�h�1��@e�H^N�h>��E`����\��;»�4 ���������3����ur�6��O(�PBF�~��?�����f�΍��Gj��w.%0ې�׭XV���`�FWϷ�]&f fYH;��W:BSfa�-��9�a�zO���`y�Yj�`��a�z���G#�{�08�	�;�V�ŵ��v��^�7%A�ߌr�Zˏ��%7��q�")�� @Y�bc����LU�! M_��b��C�zq���G�2�p v'mM/��H��3�Y�/V�}���~LH�GH�iU_�7���YBe�l�:FM�TUc���^2���<Yޕ���1"���13|���.�!v�at}R�׫��ԱEń�"����.�f�}���@�/�w��+}#oQ+?�+y��x�kb��a�$
�1+8V>C���;,�:���#�BYS�PJ [	  ȿ�,F���)���2���Ό3"rz~�H�b 0��ߜ'?�UeMٿ�,>�)�����6۲�L2nO������z��̧�,}�|�O����������;�3f9�?e/�2}ٔ���h��3_l9oeYƻs�p����d7ϒw���`�L���}�ɲR���a�{�^יg+Q7ڝ��M
vz��f*�cM�N�3��[MM�����-gp������(�mR��G�z)�S�b���lݣ� �� �������.���0�ֶ���<1��GO�T�Ì�L[����F�&�Y�}�!�@S���S�uR�P���L�"��z������p�,����~���=���;�ZoX�k�+k�ttk��OR(�5T��Qa_�2�2)�zE����Sv�D����@G�e�G`��	�w���B~��S��q�m�61��|	+��C�p����w{��fM���B��u�|C0�_iJ7g��"���Y�>�=N�&�X;i�+04f��ĖK��ߺ��A�������	3Z|�b��GV�wa��j���l����6!AǗ�'�r�7��ac�����{�=\Փ�qk�I]�����p�f�r½�|��:���G~��u-m�g�~7����6~���O�X�?�7G��a;�d�j��"�Q>u�NY���%���d6]Α�Q�{/3)�����!�C����<q����a��j�;hq��d�I�gW��[�>}mܼ����D#5K%�!�dH��f^yZd�"k���^��	k�{BQB�*���������y\|L�� �jb��5Ys��%B�� ��g�8�1�G�p�f�'��¨���@(oϞ�D�[����C&�{<�u<�%���Ρg<&Ǔ��N{)&�go�nf�=0rx�����! O�_�uP�F��>Jj�r�@��W:��M�2�65HTx���sO�7upX_�f![Cv�RF�aZ�	�86�<L��{�bK�nCZ�����/S�~����1.�(d�RT�a_��><vun�}4e��+Y�ܲ�G�)x��b͏!Q|}q�Uoڪ{*��z��"ul����$$!�K'��xj�d�K�]������;x�u�y�{9F03������B�A���q�ޞ�����{���~���-I;������ԃ��Q���_7��Bб�!���qj�g���D����X��):,=M͈��M�(=��i#�{n��#F���46��S<O������Y��7�h[�߲~�.}��ħक���R�D'�Q%���-���ci��9��ȓa
�8�jyb�O�@�7}%��U�����!��e�yltiq�y��,l�,]ܲ@��>O^���~����
'��^��?�q?�Z}�ҽ~K���k-�=��Vܵ	�/��jcuv�,�
��DSYi[��e�MȬ�J�}w&�g��K���|bS:�����Cq ����cP�_���&v3�^�[�P>cQ��a�ڗ��2�l��C톳����#4��Ws|��\w�|�ڙ7�� ��$������ys.�64�c�~��E3���	Y>0`M���֖Xn;�f�t묩+P��t�3
7�pKt�4e.OЕ�N[�0��'�<����\�RJ��g!�*�I!��ؾB����*�>��E�@;�*m ��$��3@m{���_.n�'��-����O����e�7�y�Ym/6�8v[���t���*z��Pb�I��z63ux� @�c*�Ex��[��ir��Ť%q�{ ���Z
�(L�� �g�^��<1!����¸�Gh?`h2YLx�@DU͐�^�����Er�?#����l����2��x"Y���3iϓA�c	��@��%���P\��E29��ȴ0ڳ�/����X�>�F�����b����'�$�ƕ��K_{o�8�vW����ៗ;����4#D��8�M����2vF�@�4=�� ��dp�>�ٱT8w��~.M��n�P�
�����]����uv����V�ۗ��'���_?1эBڽ|w���Lt����S3!]�]	��ȃa��*Wa}l�V)������>��V@Ke��R�)�/aI�����Q�{�O�Йm��ԿLڴm��)��z�~���C�J@�Ւ���퉞��H&	.o{t^�n�zid����'�~Ф�3��C08P�;mL�
#����e�(t{�M��H�l�1� �l]Ȱ���1�ҏ.v��[=�R҉���
�g�4�p�a������h�ɸw����v�f|��8��λ�8vy��j�ah����O��l��bF����IT�G9S�1C!�������J�m`|V�?a�kn��a��7�x6���-��U��     