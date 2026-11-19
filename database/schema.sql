-- DocTient: Supabase Database Schema
-- -------------------------------------------------------------
-- Table 1: doctor_reviews with Row Level Security & Soft Delete
-- -------------------------------------------------------------

create table if not exists public.doctor_reviews (
  id bigint generated always as identity primary key,
  name text not null,
  initials text not null,
  rating integer not null default 5 check (rating >= 1 and rating <= 5),
  comment text not null,
  tags text not null default '',
  visit text not null,
  helpful integer not null default 0,
  is_mine boolean not null default true,
  deleted_at timestamptz,                -- for soft delete
  created_at timestamptz not null default now()
);

-- Indexes for doctor_reviews
create index if not exists idx_doctor_reviews_name on public.doctor_reviews (name);
create index if not exists idx_doctor_reviews_created_at on public.doctor_reviews (created_at desc);

-- Grant anon access and enable Row Level Security (RLS)
grant select, insert, update, delete on public.doctor_reviews to anon;
alter table public.doctor_reviews enable row level security;

-- Open policies for doctor_reviews
create policy "read_all" on public.doctor_reviews for select to anon using (true);
create policy "insert_all" on public.doctor_reviews for insert to anon with check (true);
create policy "update_all" on public.doctor_reviews for update to anon using (true) with check (true);
create policy "delete_all" on public.doctor_reviews for delete to anon using (true);

-- -------------------------------------------------------------
-- Table 2: patients (Patient accounts & health records)
-- -------------------------------------------------------------

create table if not exists public.patients (
  id bigint generated always as identity primary key,
  first_name text not null,
  last_name text not null,
  email text not null unique,
  password text not null,
  phone_number text default '',
  last_login_at timestamptz,
  deleted_at timestamptz,                -- for soft delete
  created_at timestamptz not null default now()
);

create index if not exists idx_patients_email on public.patients (email);

grant select, insert, update, delete on public.patients to anon;
alter table public.patients enable row level security;

create policy "read_all_patients" on public.patients for select to anon using (true);
create policy "insert_all_patients" on public.patients for insert to anon with check (true);
create policy "update_all_patients" on public.patients for update to anon using (true) with check (true);
create policy "delete_all_patients" on public.patients for delete to anon using (true);

-- -------------------------------------------------------------
-- Table 3: doctors (Medical practitioner profiles & specialties)
-- -------------------------------------------------------------

create table if not exists public.doctors (
  id bigint generated always as identity primary key,
  first_name text not null,
  last_name text not null,
  email text not null unique,
  specialty text not null default 'General Practitioner',
  hospital_or_clinic text default 'Makati Med',
  is_online boolean not null default true,
  password text not null,
  last_login_at timestamptz,
  deleted_at timestamptz,                -- for soft delete
  created_at timestamptz not null default now()
);

create index if not exists idx_doctors_email on public.doctors (email);
create index if not exists idx_doctors_specialty on public.doctors (specialty);

grant select, insert, update, delete on public.doctors to anon;
alter table public.doctors enable row level security;

create policy "read_all_doctors" on public.doctors for select to anon using (true);
create policy "insert_all_doctors" on public.doctors for insert to anon with check (true);
create policy "update_all_doctors" on public.doctors for update to anon using (true) with check (true);
create policy "delete_all_doctors" on public.doctors for delete to anon using (true);
