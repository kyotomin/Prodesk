CREATE TYPE "project_status" AS ENUM (
  'planned',
  'in_progress',
  'finished'
);

CREATE TABLE "projects" (
  "id" uuid PRIMARY KEY NOT NULL DEFAULT (uuidv7()),
  "title" text NOT NULL,
  "description" text,
  "status" project_status NOT NULL DEFAULT 'planned',
  "created_at" timestamptz NOT NULL DEFAULT (now()),
  "updated_at" timestamptz NOT NULL DEFAULT (now())
);

CREATE TABLE "employees" (
  "id" uuid PRIMARY KEY NOT NULL DEFAULT (uuidv7()),
  "full_name" text NOT NULL,
  "email" text UNIQUE NOT NULL,
  "position" text NOT NULL,
  "experience_years" smallint NOT NULL DEFAULT 0,
  "created_at" timestamptz NOT NULL DEFAULT (now()),
  CHECK (experience_years >= 0)
);

CREATE TABLE "skills" (
  "id" uuid PRIMARY KEY NOT NULL DEFAULT (uuidv7()),
  "name" text UNIQUE NOT NULL,
  "created_at" timestamptz NOT NULL DEFAULT (now())
);

CREATE TABLE "employee_skills" (
  "employee_id" uuid NOT NULL,
  "skill_id" uuid NOT NULL,
  "level" smallint NOT NULL,
  CHECK (level BETWEEN 1 AND 5),
  PRIMARY KEY ("employee_id", "skill_id")
);

CREATE TABLE "project_required_skills" (
  "project_id" uuid NOT NULL,
  "skill_id" uuid NOT NULL,
  "min_level" smallint NOT NULL DEFAULT 1,
  CHECK (min_level BETWEEN 1 AND 5),
  PRIMARY KEY ("project_id", "skill_id")
);

CREATE TABLE "project_members" (
  "project_id" uuid NOT NULL,
  "employee_id" uuid NOT NULL,
  "role" text NOT NULL,
  "assigned_at" timestamptz NOT NULL DEFAULT (now()),
  PRIMARY KEY ("project_id", "employee_id")
);

CREATE INDEX ON "employee_skills" ("skill_id");

CREATE INDEX ON "project_required_skills" ("skill_id");

CREATE INDEX ON "project_members" ("employee_id");

ALTER TABLE "employee_skills" ADD FOREIGN KEY ("employee_id") REFERENCES "employees" ("id") ON DELETE CASCADE;

ALTER TABLE "employee_skills" ADD FOREIGN KEY ("skill_id") REFERENCES "skills" ("id") ON DELETE RESTRICT;

ALTER TABLE "project_required_skills" ADD FOREIGN KEY ("project_id") REFERENCES "projects" ("id") ON DELETE CASCADE;

ALTER TABLE "project_required_skills" ADD FOREIGN KEY ("skill_id") REFERENCES "skills" ("id") ON DELETE RESTRICT;

ALTER TABLE "project_members" ADD FOREIGN KEY ("project_id") REFERENCES "projects" ("id") ON DELETE CASCADE;

ALTER TABLE "project_members" ADD FOREIGN KEY ("employee_id") REFERENCES "employees" ("id") ON DELETE RESTRICT;
